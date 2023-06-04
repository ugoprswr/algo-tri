using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace algo_tri
{
    public class BaseTriForm : Form
    {
        protected int[] array;
        protected int currentIndex;
        protected int[] sortedArray;

        protected const int arraySize = 10;
        protected const int minValue = 1;
        protected const int maxValue = 18;

        protected const int cellWidth = 40;
        protected const int cellHeight = 40;

        protected const int startX = 50;
        protected const int startY = 50;

        protected const int delay = 500; // Délai entre chaque itération en millisecondes

        protected Timer timer;

        protected TextBox txbPseudoCode;
        protected TextBox txbCode;

        public BaseTriForm()
        {
            InitializeArray();
            InitializeTimer();
            DoubleBuffered = true;
        }
        protected virtual void InitializeArray()
        {
            Random random = new Random();
            array = new int[arraySize];
            HashSet<int> generatedNumbers = new HashSet<int>();

            for (int i = 0; i < arraySize; i++)
            {
                int randomNumber;
                do
                {
                    randomNumber = random.Next(minValue, maxValue + 1);
                } while (generatedNumbers.Contains(randomNumber));

                generatedNumbers.Add(randomNumber);
                array[i] = randomNumber;
            }
        }

        protected virtual void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = delay;
            timer.Tick += Timer_Tick;
        }

        protected virtual void Timer_Tick(object sender, EventArgs e)
        {
            // Code spécifique au tri pour chaque formulaire dérivé
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // Code spécifique au dessin pour chaque formulaire dérivé
        }

        protected void StartTimer()
        {
            currentIndex = 0;
            timer.Start();
        }

        protected int GetDelayFromSpeed(string speed)
        {
            switch (speed)
            {
                case "Lent":
                    return 1000; // Délai de 1 seconde (vitesse lente)
                case "Rapide":
                    return 200; // Délai de 200 millisecondes (vitesse rapide)
                default:
                    return 500; // Délai par défaut de 500 millisecondes
            }
        }
    }
}
