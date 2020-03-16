namespace Struct1
{
    public struct Coffee1
    {
        private int strength1;
        public int Strengrh1
        {
            get
            {
                return strength1;
            }
            set
            {
                if (value < 1)
                {
                    strength1 = 1;
                }
                else if (value > 5)
                {
                    strength1 = 5;
                }
                else
                {
                    strength1 = value;
                }
            }
        }
    }
    public struct Menu
    {
        public string[] beverages;
        public Menu (string bev1, string bev2)
        {
            beverages = new string[]
            {
                "Americano", "Cafe au Lait", "Cafe Macchiato", "Cappucino", "Espresso", bev1, bev2
            };
        }
    }
}