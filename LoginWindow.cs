﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using MowChat.Data;
using MowChat.Properties;

namespace MowChat
{
	public partial class LoginWindow : Form
	{
		private enum Status
		{
			Init,
			ContactingServer,
			WaitingForLogin,
			SelectCharacter,
			SelectingCharacter,
			ObtainingChats,
			Done,
		}

		private Timer _timer;
		private AuthToken _token;

		private Status _status = Status.Init;

		public LoginWindow()
		{
			InitializeComponent();
		}

		private void LoginWindow_Load(object sender, EventArgs e)
		{
			// Start by obtaining a token
			API.Instance.Get<AuthToken>(OnTokenReceived, "auth/current");

			SetStatus(Status.ContactingServer);
		}

		private void SetStatus(Status status)
		{
			string desiredText;
			_status = status;

			switch (_status)
			{
				case Status.Init:
					desiredText = Resources.Login_Initialising;
					break;
				case Status.ContactingServer:
					desiredText = Resources.Login_ContactingServer;
					break;
				case Status.WaitingForLogin:
					desiredText = Resources.Login_WaitingForLogin;
					break;
				case Status.SelectCharacter:
					desiredText = Resources.Login_SelectCharacter;
					break;
				case Status.SelectingCharacter:
					desiredText = Resources.Login_SelectingCharacter;
					break;
				case Status.ObtainingChats:
					desiredText = Resources.Login_ObtainingChats;
					break;
				case Status.Done:
					desiredText = Resources.Login_Done;
					break;
				default:
					throw new ArgumentOutOfRangeException();
			}

			Invoke((MethodInvoker) delegate
				{
					loginStatus.Text = desiredText;
				});
		}

		private void OnTokenReceived(AuthToken token)
		{
			SetStatus(Status.WaitingForLogin);

			_token = token;

			// Open the browser on the login page.
			Process.Start(token.Url);

			// Start trying the login every second
			_timer = new Timer {Interval = 1000};
			_timer.Tick += AttemptLogin;

			Invoke((MethodInvoker)(() => _timer.Start()));
		}

		private void AttemptLogin(object sender, EventArgs eventArgs)
		{
			API.Instance.Post<User>(OnLoginComplete, "auth/consume", new Dictionary<string, string>
				{
					{ "token", _token.Token },
					{ "version", "1" }
				});
		}

		private void OnLoginComplete(User user)
		{
			// Stop trying
			Invoke((MethodInvoker) delegate
				{
					_timer.Stop();
					Focus();
					BringToFront();
				});

			SetStatus(Status.SelectCharacter);

			// Open character select window
			var window = new CharacterSelect(user.Characters, OnCharacterChosen);
			window.Closing += OnCharacterSelectClosed;
			Invoke((MethodInvoker) (() => window.ShowDialog(this)));
		}

		private void OnCharacterSelectClosed(object sender, CancelEventArgs e)
		{
			if (_status != Status.SelectingCharacter)
			{
				Invoke((MethodInvoker) Close);
			}
		}

		private void OnCharacterChosen(Character character)
		{
			SetStatus(Status.SelectingCharacter);

			API.Instance.Post<Character>(OnCharacterSelected, string.Format("players/{0}/select", character.Id));
		}

		private void OnCharacterSelected(Character character)
		{
			SetStatus(Status.ObtainingChats);

			API.Instance.Get<ChatChannelList>(OnChannelsObtained, "chat/channels");
		}

		private void OnChannelsObtained(ChatChannelList channels)
		{
			SetStatus(Status.Done);
		
			// Let's wait a second so the people can see the "Done" message... and kick off WebSync!
			var t = new Timer {Interval = 1000};
			t.Tick += delegate
				{
					t.Stop();
					Close();
				};
			Invoke((MethodInvoker) t.Start);
		}
	}
}