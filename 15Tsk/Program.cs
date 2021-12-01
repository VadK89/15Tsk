using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Tsk
{
    /*Разработать интерфейс ISeries генерации ряда чисел. Интерфейс содержит следующие элементы:
      •	метод void setStart(int x) - устанавливает начальное значение
      •	метод int getNext() - возвращает следующее число ряда
      •	метод void reset() - выполняет сброс к начальному значению
       Разработать классы ArithProgression и GeomProgression, которые реализуют интерфейс ISeries.
    В классах реализовать методы интерфейса в соответствии с логикой 
    арифметической и геометрической прогрессии соответственно. */
    class Program
    {
        static void Main(string[] args)
        {
            //Задаение параметров для арифметической прогрессии
            Console.WriteLine("Введите значение шага арифметической прогрессии");
            int step = Convert.ToInt32(Console.ReadLine());
            ArithProgression arithProgression = new ArithProgression(step);
            Console.WriteLine("Введите значение первого элемента арифметической прогрессии");
            int ela = Convert.ToInt32(Console.ReadLine());
            arithProgression.setStart(ela);
            Console.WriteLine("Введите количество членов прогрессии");
            int lengar = Convert.ToInt32(Console.ReadLine());
            //Вывод прогрессии
            Console.WriteLine("Арифметическая прогрессия:");
            Console.WriteLine(ela);
            for (int i = 0; i < lengar; i++)
            {
                arithProgression.getNext();
                Console.WriteLine(arithProgression.NextEl);
            }  
            //проверка метода сброса
            arithProgression.reset();
            Console.WriteLine("Значение первого элемента арифметической прогрессии после сброса", arithProgression.NextEl);
            
            //Задание параметров геометрической прогрессии
            Console.WriteLine("Введите значение знаменателя геометрической прогрессии");
            int znam = Convert.ToInt32(Console.ReadLine());
            GeomProgression geomProgression = new GeomProgression(znam);
            Console.WriteLine("Введите значение первого элемента геометрической прогрессии");
            int elg = Convert.ToInt32(Console.ReadLine());
            geomProgression.setStart(elg);
            Console.WriteLine("Введите количество членов геометрической прогрессии");
            int lengge = Convert.ToInt32(Console.ReadLine());
            //Вывод прогрессии
            Console.WriteLine("Геометрическая прогрессия:");
            Console.WriteLine(elg);
            for (int i = 0; i < lengge - 1; i++)
            {
                geomProgression.getNext();
                Console.WriteLine(geomProgression.NextGeo);
            }
            //проверка метода сброса
            geomProgression.reset();
            Console.WriteLine("Значение первого элемента геометрической прогрессии после сброса", geomProgression.NextGeo);
            Console.ReadKey();
        }
    }
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }
    class ArithProgression : ISeries
    {
        public int FirstEl; 
        public int StepAr;
        public int NextEl { get; set; }
        
        public ArithProgression(int Step)
        {
            StepAr = Step;
        }
         public void setStart(int x)
        {
            NextEl = x;
            FirstEl = NextEl;
        }

        public int getNext()
        {
            NextEl += StepAr;
            return NextEl;
        }

        public void reset()
        {
            NextEl = FirstEl;
            return;
        }        
    }
    class GeomProgression : ISeries
    {
        public int FirstGeo;
        public int NextGeo;
        public int Znam;
        public GeomProgression(int ZN)
        {
            Znam = ZN;
        }
        public void setStart(int x)
        {
            NextGeo = x;
            FirstGeo = NextGeo;
        }
        public int getNext()
        {
            NextGeo = NextGeo * Znam;
            return NextGeo;
        }

        public void reset()
        {
            NextGeo = FirstGeo;
            return;
        }

       
    }
}
