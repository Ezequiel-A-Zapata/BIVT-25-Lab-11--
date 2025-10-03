namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here

                if (a > 0 && b > 0)
                {
                    answer = true;
                }
                else if (a < 0 && b < 0)
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                }
            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            double n = Math.Truncate(d);
            double f = Math.Abs(d - n);
            if (f >= 0.0001)
            {
                answer = true;
            }
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (b != 0 && a % b == 0)
            {
                answer = true;        
            }
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            double abs_d = Math.Abs(d);
            double abs_f = Math.Abs(f);
            double abs_g = Math.Abs(g);

            double n_max = Math.Max(abs_d, Math.Max(abs_f, abs_g));
            if (n_max == abs_d)
            {
                answer = d;
            } 
            else if (n_max == abs_f)
            {
                answer = f;
            } 
            else 
            {
                answer = g;
            }
            // end

            return answer;
        }
    public double Task5(double x)
    {
        double answer = 0;  

        // code here
        if (x < -1)
        {
            answer = 0;
        }
        else if (x >= -1 && x <= 0)
        {
            answer = x + 1;
        }
        else if (x > 0 && x <= 1)
        {
            answer = 1;
        }
        else  // x > 1
        {
            answer = 1;
        }
        // end

        return answer;
    }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            double r = Math.Sqrt(circleS / Math.PI);
            double a = Math.Sqrt(squareS);
            if (2 * r <= a)
            {
                answer = true;
            }
            // end

            return answer;
        }

        public double Task7(double d, double f)
        {
            double answer = 0;

            // code here
            if (Math.Abs(d) < Math.Abs(f))
            {
                if (d > 0)
                {
                    answer = -1;
                }

            }
            else
            {
                if (f > 0)
                {
                    answer = 1;
                }

            return answer;
        }

        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            int A = a / 2;
            int B = b / 2;
            int C = c / 2;
            int S = A + B + C;

            if (S % 3 == 0)
            {
                int k = S / 3;
                if (k >= 1 && k <= a && k <= b && k <= c)
                    answer = true;
            }

            if (!answer && (S + 1) % 3 == 0)
            {
                int k = (S + 1) / 3;
                if (k >= 1 && k <= a && k <= b && k <= c)
                    answer = true;
            }
            // end

            return answer;
        }
    }
}  



