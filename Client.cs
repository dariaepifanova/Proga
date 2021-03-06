﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Proga
{
    [Serializable]
    public class Client : ISerializable
    {
        private string name;
        private int id;
        private bool status;

        public Client() { }
        public Client(string name, int id, bool status)
        {
            Name = name;
            if (id < 0)
                throw new ArgumentOutOfRangeException("Id is not correct!");
            this.id = id;
            this.status = status;
        }

        public Client(SerializationInfo info, StreamingContext content)
        {
            this.name = (string)info.GetValue("Name", typeof(string));
            this.id = (int)info.GetValue("Id", typeof(int));
            this.status = (bool)info.GetValue("Status", typeof(int));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext content)
        {
            info.AddValue("Name", this.name);
            info.AddValue("Id", this.id);
            info.AddValue("Status", this.status);
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public bool Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }

        }
        public int Id
        {
            get
            {
                return id;
            }
        }
    }
}
