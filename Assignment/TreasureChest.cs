namespace Assignment
{
    class TreasureChest
    {
        private State _state = State.Locked;
        private readonly Material _material;
        private readonly LockType _lockType;
        private readonly LootQuality _lootQuality;

        public TreasureChest()
        {
            _material = Material.Iron;
            _lockType = LockType.Expert;
            _lootQuality = LootQuality.Green;
        }
        public TreasureChest(State state) : this()
        {
            _state = state;
        }
        {
            throw new NotImplementedException();
        }

        public TreasureChest(Material material, LockType lockType, LootQuality lootQuality, LootQuality LootQuality)
        {
           // throw new NotImplementedException();
            material = Material.Iron;
            lockType = LockType.Expert;
            LootQuality = LootQuality.Green;
        }

        public State Manipulate(Action action)
        {
            //throw new NotImplementedException();
            switch(action)
            {
                case Action.lock:
                    Lock();
                    break;
                case Action.Unlock:
                    Unlock();
                    break;
                case Action.Open:
                    Open();
                    break;
                case Action.Close:
                    Close();
                    break;
                
                }
                return _state;
            }
        }

        /*private void Open()
        {
            throw new NotImplementedException();
        }*/

        public void Unlock()
        {
           // throw new NotImplementedException();
           if (_state == State.Locked)
           {
            _state = State.Closed;
           }
           else if (_state == State.Closed)
           {
            Console.WriteLine("chest will not unlocked when it is closed");
           }
           else if (_state == State.Open)
           {
            Console.WriteLine("chest will not unlocked when it is open");
           }
        }
        //lock treasure chest
        public void Lock()
        {
           // throw new NotImplementedException();
           if (_state == State.Closed)
           {
            _state = State.Locked;
           }
           else if (_state == State.Locked)
           {
            Console.WriteLine("chest is locked when it is closed");
           }
           else if (_state == State.Open)
           {
            Console.WriteLine("chest will not locked when it is open");
           }
        }
        }
        //open treasure chest
        public void Open()
        {
            //throw new NotImplementedException();
            if (_state == State.Closed)
           {
            _state = State.Open;
           }
           else if (_state == State.Open)
           {
            Console.WriteLine("chest is open");
           }
           else if (_state == State.Locked)
           {
            Console.WriteLine("chest is locked");
           }
        }
        }
        //close treasure chest
        public void Close()
        {
            //throw new NotImplementedException();
            if (_state == State.Open)
           {
            _state = State.Closed;
           }
           else if (_state == State.Closed)
           {
            Console.WriteLine("chest is closed");
           }
           else if (_state == State.Locked)
           {
            Console.WriteLine("chest is locked");
           }
        }

        public override string ToString()
        {
            return $"A {_state} chest with the following properties:\nMaterial: {_material}\nLock Type: {_lockType}\nLoot Quality: {_lootQuality}";
        }

        private static void ConsoleHelper(string prop1, string prop2, string prop3)
        {
            Console.WriteLine($"Choose from the following properties.\n1.{prop1}\n2.{prop2}\n3.{prop3}");
        }

        public enum State { Open, Closed, Locked };
        public enum Action { Open, Close, Lock, Unlock };
        public enum Material { Oak, RichMahogany, Iron };
        public enum LockType { Novice, Intermediate, Expert };
        public enum LootQuality { Grey, Green, Purple };
    }
}
