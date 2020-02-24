using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day_2
{
    class Common
    {
        protected void ExecuteIntCode(List<int> prog)
        {

            for (var i = 0; i < prog.Count; i += 4)
                {
                    var op = prog[i];

                    if (op == 99)
                    {
                        break;
                    }

                    var arg1 = prog[prog[i + 1]];
                    var arg2 = prog[prog[i + 2]];

                    if (op == 1)
                    {
                        //Addition.
                        var result = arg1 + arg2;
                        prog[prog[i + 3]] = result;
                    }
                    else if (op == 2)
                    {
                        // Multiplication.
                        var result = arg1 * arg2;
                        prog[prog[i + 3]] = result;
                    }
                    else
                    {
                        //throw new InvalidOperationException("Invalid OpCode");
                        Console.Write($"Invalid Opcode. ");
                        break;
                    }

                }
        }
    }
}
