﻿namespace Demo.Models
{
    internal class User : IdObject
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }
    }
}