﻿namespace HirokiBackend.Models
{
    public class UsuarioModel
    {
        public int id { get; set; }
        public string firstName { get; set; }

        public string lastName { get; set; }

        public string address { get; set; }

        public string phone { get; set; }

        public string email { get; set; }

        public string username { get; set; }

        public int password { get; set; }
    }
}
