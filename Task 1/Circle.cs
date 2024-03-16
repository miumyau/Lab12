namespace Task_1
{
   
         static class Circle
    
        {
            static  public string GetLenth(double r)
            {

                return $"Длина окружности {2 * Math.PI * r}";



            }
        static public string GetSquare(double r)
            {
                
                    return $"Площадь окружности {Math.PI * r*r}";


            }

        static public string IsPoinHere (double r,double x, double y, double x0, double y0)
            {
                if ((x - x0)* (x - x0) + (y - y0)* (y - y0) <= r*r)
                return "Точка принадлежит окружности";

                else
                return "Точка не принадлежит окружности";
            }
        }
    }
