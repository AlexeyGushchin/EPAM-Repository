using System;
using Get;


namespace Task_1._1._6
{
    class Program
    {
        static void Main()
        {
            var font = new FontAdjustment();

            Console.WriteLine("Для смены стиля выберете его номер:" +
                "\n\t 1 - bold\n\t 2 - italic \n\t 3 - underline\n");

            while (true)
            {
                font.ShowSetFonts();

                int dec = GetFromUser.GetPositiveIntNoMore(3, "Выберете значение из списка\n");

                switch (dec)
                {
                    case (1):
                        font.SetFont = Fonts.bold;
                        break;

                    case (2):
                        font.SetFont = Fonts.italic;
                        break;

                    case (3):
                        font.SetFont = Fonts.underline;
                        break;

                }
            }
        }
    }


    [Flags]
    enum Fonts : byte
    {
        None = 0,
        bold = 1,
        italic = 2,
        underline = 4

    }
    class FontAdjustment
    {
        private Fonts setFonts;

        public Fonts SetFont
        {
            get { return setFonts; }

            set
            {
                if (setFonts.HasFlag(value))
                {
                    setFonts ^= value;
                    Console.WriteLine("\n" + value + " был отключен!");
                }
                else
                {
                    setFonts |= value;
                    Console.WriteLine("\n" + value + " подключен!");
                }

            }
        }

        public void ShowSetFonts()
        {
            Console.WriteLine("Параметры надписи: " + setFonts.ToString() + "\n");
        }
    }
}
