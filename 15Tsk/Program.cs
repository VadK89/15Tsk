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
            Console.WriteLine("Введите значение первого элемента арифметической прогрессии");
            int ela = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение шага арифметической прогрессии");
            int step = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество членов прогрессии");
            int lengar = Convert.ToInt32(Console.ReadLine());
            ArithProgression arithProgression = new ArithProgression(step);
            arithProgression.SetStart(ela);
            //Вывод прогрессии
            Console.WriteLine("Арифметическая прогрессия:");
            Console.WriteLine(ela);
            
            for (int i = 0; i < lengar; i++)
            {
                arithProgression.GetNext();
                Console.WriteLine(arithProgression.NextEl);
            }  
            //проверка метода сброса
            arithProgression.Reset();
            //Задание начальных значений геометрической прогрессии
            Console.WriteLine("Введите значение первого элемента геометрической прогрессии");
            int elg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение знаменателя геометрической прогрессии");
            int znam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество членов геометрической прогрессии");
            int lengge = Convert.ToInt32(Console.ReadLine());
            GeomProgression geomProgression = new GeomProgression(znam);            
            geomProgression.SetStart(elg);            
            //Вывод прогрессии
            Console.WriteLine("Геометрическая прогрессия:");
            Console.WriteLine(elg);
            for (int i = 0; i < lengge - 1; i++)
            {
                geomProgression.GetNext();
                Console.WriteLine(geomProgression.NextGeo);
            }
            //проверка метода сброса
            geomProgression.Reset();
            Console.ReadKey();
        }
    }
    interface ISeries
    {
        void SetStart(int x);
        int GetNext();
        void Reset();
    }
    class ArithProgression : ISeries
    {
        int FirstEl; 
        int StepAr;
        int ArLength;
        public int NextEl { get; set; }
        
        public ArithProgression(int Step)
        {
            StepAr = Step;            
        }
         public void SetStart(int x)
        {
            FirstEl = x;
            NextEl = FirstEl;
        }

        public int GetNext()
        {
            NextEl += StepAr;
            return NextEl;
        }
        public void Reset()
        {
            NextEl = FirstEl;
            Console.WriteLine("Первый элемент арифметической прогрессии после сброса {0}", NextEl);
            return;
        }        
    }
    class GeomProgression : ISeries
    {
        public int FirstGeo;
        public int NextGeo;
        public int StepGeo;
        public GeomProgression(int ZN)
        {
            StepGeo = ZN;
        }
        public void SetStart(int x)
        {
            FirstGeo = x;
            NextGeo = FirstGeo;
        }
        public int GetNext()
        {
            NextGeo = NextGeo * StepGeo;
            return NextGeo;
        }

        public void Reset()
        {
            NextGeo = FirstGeo;
            Console.WriteLine("Первый элемент геометричевской прогрессии после сброса {0}", NextGeo);
            return;
        }

       
    }
}
