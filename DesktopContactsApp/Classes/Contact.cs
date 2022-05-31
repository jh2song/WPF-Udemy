﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesktopContactsApp.Classes
{
	class Contact
	{
		[PrimaryKey, AutoIncrement]

		public int Id { get; set; }

		public string Name { get; set; }

		public string Email { get; set; }

		public string Phone { get; set; }
	}
}
