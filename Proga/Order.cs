using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Proga
{
    [Serializable]
    class Order : ISerializable
    {
        private int id;
        private Client client;
        private Skates skates;

        public Order() { }

        public Order(int id, Client client, Skates skates)
        {
            if (id < 0)
                throw new ArgumentOutOfRangeException("Id is not correct!");
            this.id = id;
            Client = client;
            Skates = skates;
        }

        public Order(SerializationInfo info, StreamingContext content)
        {
            this.id = (int)info.GetValue("Id", typeof(int));
            this.client = (Client)info.GetValue("Client", typeof(Client));
            this.skates = (Skates)info.GetValue("Skates", typeof(Skates));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext content)
        {
            info.AddValue("Id", this.id);
            info.AddValue("Client", this.client);
            info.AddValue("Skates", this.skates);
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public Skates Skates
        {
            get
            {
                return skates;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Skates is null!");
                skates = value;
            }
        }

        public Client Client
        {
            get
            {
                return client;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Client is null!");
                client = value;
            }
        }
    }
}
