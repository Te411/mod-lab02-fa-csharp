using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fans
{
  public class State
  {
    public string Name;
    public Dictionary<char, State> Transitions;
    public bool IsAcceptState;
  }

  public class FA1
  {
        /// <summary>
        /// Состояние "A"
        /// </summary>
        public static State stateA = new State()
        {
            Name = "A",
            IsAcceptState = false,
            Transitions = new Dictionary<char, State>()
        };

        /// <summary>
        /// Состояние "B"
        /// </summary>
        public State stateB = new State()
        {
            Name = "B",
            IsAcceptState = false,
            Transitions = new Dictionary<char, State>()
        };

        /// <summary>
        /// Состояние "C"
        /// </summary>
        public State stateC = new State()
        {
            Name = "C",
            IsAcceptState = false,
            Transitions = new Dictionary<char, State>()
        };

        /// <summary>
        /// Состояние "D"
        /// </summary>
        public State stateD = new State()
        {
            Name = "D",
            IsAcceptState = true,
            Transitions = new Dictionary<char, State>()
        };

        /// <summary>
        /// Состояние "E"
        /// </summary>
        public State stateE = new State()
        {
            Name = "E",
            IsAcceptState = false,
            Transitions = new Dictionary<char, State>()
        };


        State InitialState;

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public FA1()
        {
            InitialState = stateA;

            stateA.Transitions['0'] = stateC;
            stateA.Transitions['1'] = stateB;

            stateB.Transitions['0'] = stateD;
            stateB.Transitions['1'] = stateB;

            stateC.Transitions['0'] = stateE;
            stateC.Transitions['1'] = stateD;

            stateD.Transitions['0'] = stateE;
            stateD.Transitions['1'] = stateD;

            stateE.Transitions['0'] = stateE;
            stateE.Transitions['1'] = stateE;
        }

        /// <summary>
        /// Запустить конечный автомат
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool? Run(IEnumerable<char> s)
        {
            State current = InitialState;
            foreach (var item in s)
            {
                current = current.Transitions[item];
                if (current == null)
                {
                    return null;
                }
            }
            return current.IsAcceptState;
        }
    }

  public class FA2
  {
        /// <summary>
        /// Состояние "A"
        /// </summary>
        public static State stateA = new State()
        {
            Name = "a",
            IsAcceptState = false,
            Transitions = new Dictionary<char, State>()
        };

        /// <summary>
        /// Состояние "B"
        /// </summary>
        public State stateB = new State()
        {
            Name = "b",
            IsAcceptState = false,
            Transitions = new Dictionary<char, State>()
        };

        /// <summary>
        /// Состояние "C"
        /// </summary>
        public State stateC = new State()
        {
            Name = "c",
            IsAcceptState = false,
            Transitions = new Dictionary<char, State>()
        };

        /// <summary>
        /// Состояние "D"
        /// </summary>
        public State stateD = new State()
        {
            Name = "d",
            IsAcceptState = true,
            Transitions = new Dictionary<char, State>()
        };

        State InitialState;

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public FA2()
        {
            InitialState = stateA;

            stateA.Transitions['0'] = stateC;
            stateA.Transitions['1'] = stateB;

            stateB.Transitions['0'] = stateD;
            stateB.Transitions['1'] = stateA;

            stateC.Transitions['0'] = stateA;
            stateC.Transitions['1'] = stateD;

            stateD.Transitions['0'] = stateB;
            stateD.Transitions['1'] = stateC;
        }

        /// <summary>
        /// Запустить конечный автомат
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool? Run(IEnumerable<char> s)
        {
            State current = InitialState;
            foreach (var item in s)
            {
                current = current.Transitions[item];
                if (current == null)
                {
                    return null;
                }
            }
            return current.IsAcceptState;
        }
   }
  
  public class FA3
  {
        /// <summary>
        /// Состояние "A"
        /// </summary>
        public static State stateA = new State()
        {
            Name = "a",
            IsAcceptState = false,
            Transitions = new Dictionary<char, State>()
        };

        /// <summary>
        /// Состояние "B"
        /// </summary>
        public State stateB = new State()
        {
            Name = "b",
            IsAcceptState = false,
            Transitions = new Dictionary<char, State>()
        };

        /// <summary>
        /// Состояние "C"
        /// </summary>
        public State stateC = new State()
        {
            Name = "c",
            IsAcceptState = true,
            Transitions = new Dictionary<char, State>()
        };

        State InitialState;

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public FA3()
        {
            InitialState = stateA;

            stateA.Transitions['0'] = stateA;
            stateA.Transitions['1'] = stateB;

            stateB.Transitions['0'] = stateA;
            stateB.Transitions['1'] = stateC;

            stateC.Transitions['0'] = stateC;
            stateC.Transitions['1'] = stateC;
        }

        /// <summary>
        /// Запустить конечный автомат
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool? Run(IEnumerable<char> s)
        {
            State current = InitialState;
            foreach (var item in s)
            {
                current = current.Transitions[item];
                if (current == null)
                {
                    return null;
                }
            }
            return current.IsAcceptState;
        }
   }

  class Program
  {
    static void Main(string[] args)
    {
      String s = "01111";
      FA1 fa1 = new FA1();
      bool? result1 = fa1.Run(s);
      Console.WriteLine(result1);
      FA2 fa2 = new FA2();
      bool? result2 = fa2.Run(s);
      Console.WriteLine(result2);
      FA3 fa3 = new FA3();
      bool? result3 = fa3.Run(s);
      Console.WriteLine(result3);
    }
  }
}