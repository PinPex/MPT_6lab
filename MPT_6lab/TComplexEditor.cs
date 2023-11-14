using lab6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPT_6lab
{

    public abstract class TComplexEditor
    {
        private Complex number { get;  set; }
        public string Number { 
            get { return number.GetString(); }
            set { number = new Complex(value); } 
        }
        private string postReal = "";
        private string postImaginary = "";

        static public string Zero = "0+i*0";
        public TComplexEditor()
        {
            number = new Complex(Zero);
        }

        public bool isZero()
        {
            return number.Equal(new Complex(Zero));
        }

        public string AddSignImaginary()
        {
            number = new Complex(number.GetRealNumber(), -number.GetImaginaryNumber());
            return number.GetString();
        }
        public string AddSignReal()
        {
            number = new Complex(-number.GetRealNumber(), number.GetImaginaryNumber());
            return number.GetString();
        }

        public string AddDigitReal(int digit) {
            if(digit < 0 || digit > 9) {
                return GetString();
            }
            if(postReal.Length != 0)
            {
                postReal += digit.ToString();
            }
            else
            {
                if(number.GetRealNumber() != 0)
                {
                    number.Real = Double.Parse(number.GetRealString() + digit.ToString());
                }
                else
                {
                    number.Real = digit;
                }
            }
            
            return GetString();
            
        }
        public string AddDigitImaginary(int digit)
        {
            if (digit < 0 || digit > 9)
            {
                return GetString();
            }
            if (postImaginary.Length != 0)
            {
                postImaginary += digit.ToString();
            }
            else
            {
                if (number.GetImaginaryNumber() != 0)
                {
                    number.Imaginary = Double.Parse(number.GetImaginaryString() + digit.ToString());
                }
                else
                {
                    number.Imaginary = digit;
                }
            }

            return GetString();
        }

        public string AddZeroReal()
        {
            return AddDigitReal(0);
        }
        public string AddZeroImaginary()
        {
            return AddDigitImaginary(0);
        }

        public string AddDotReal()
        {
            if(postReal.Length == 0)
            {
                postReal += ".";
            }
            return GetString();
        }
        public string AddDotImaginary()
        {
            if (postImaginary.Length == 0)
            {
                postImaginary += ".";
            }
            return GetString();
        }

        public string BackspaceReal()
        {
            if(postReal.Length != 0)
            {
                postReal = postReal.Remove(postReal.Length - 1);
            }
            else
            {
                if (number.Real != 0)
                {

                    string temp = number.GetRealString();
                    if (temp.Length == 1)
                    {
                        number.Real = Double.Parse("0");
                    }
                    else
                    {
                        number.Real = Double.Parse(temp.Remove(temp.Length - 1));
                    }
                }
            }
            return GetString();
        }

        public string BackspaceImaginary()
        {
            if (postImaginary.Length != 0)
            {
                postImaginary = postImaginary.Remove(postImaginary.Length - 1);
            }
            else
            {
                if (number.Imaginary != 0)
                {
                    string temp = number.GetImaginaryString();
                    if(temp.Length == 1)
                    {
                        number.Imaginary = Double.Parse("0");
                    }
                    else
                    {
                        number.Imaginary = Double.Parse(temp.Remove(temp.Length - 1));
                    }
                }
            }
            return GetString();
        }

        public string Clear()
        {
            number = new Complex(Zero);
            postReal = "";
            postImaginary = "";
            return GetString();
        }

        private string GetRealString()
        {
            return number.GetRealString() + postReal;
        }

        private string GetImaginaryString()
        {
            return number.GetImaginaryString() + postImaginary;
        }
        private string GetString()
        {
            return (number.Real >= 0 ? "" : "-") + Math.Abs(number.Real).ToString() + postReal + (number.Imaginary >= 0 ? '+' : '-') + "i*" + Math.Abs(number.Imaginary).ToString() + postImaginary;
        }

    }
}
