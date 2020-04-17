using System;

namespace Gradebook{
    public class Analytics{
        private double sum;
        private double high;
        private double low;
        private int count;

        public double Average{
            get{
                return sum / count;
            }
        }

        public double High{
            get{
                return high;
            }
        }

        public double Low{
            get{
                return low;
            }
        }

        public char LetterGrade{
            get{
                switch(Average){
                    case var d when d >= 90:
                        return 'A';
                    case var d when d >= 80:
                        return 'B';
                    case var d when d >= 70:
                        return 'C';
                    case var d when d >= 60:
                        return 'D';
                    default:
                        return 'F';
                }
            }
        }

        public Analytics(){
            sum = 0.0;
            count = 0;
            high = double.MinValue;
            low = double.MaxValue;
        }

        public void Add(double num){
            sum += num;
            count++;
            high = Math.Max(num, high);
            low = Math.Min(num, low);
        }

    }
}