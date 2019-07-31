using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace write_to_file
{
    class Program
    {
        static void Main(string[] args)
        {

            //note only 2.1% of population overweight
            //not only .8% of population for healthy
            //obese 21%
            //overweight 30%
            //double weightFactor = .45;
            //double heightFactor = .025;
            int overweight = 30;
            int obese = 21;
            int underweight = 15;
            int hypernormal = 8;
            int hyperover = 21;
            double MaxWeight = 280;
            double MaxHeight = 79;
            double overweightBMI = 25.1;
            //double obeseBMI = 30;
            //double underweightBMI = 18.4;
            double BMI;
            double Hemoglobin = 12.5;
            int minhemo = 9;
            int maxhemo = 18;
            DateTime enddate = DateTime.Now;
            List<string> lines = new List<string>();
            lines.Add("TYPE;DATE;MEASURE");
            for (int i = 1; i <= 800; i++)
            {                
                lines.Add("PATIENT;" + i);
                double weight;
                double height;

                Random rand = new Random(42 * i * i);

                height = rand.Next(26, 50);
                BMI = rand.Next(10,33);
                weight = (BMI * ((height * .025)*(height * .025))) / .45;
                // return (weight * weightFactor) / ((heightFactor* height) * (heightFactor* height));

                double oldheight = height;
                double oldweight = weight;

                bool tendencyToGainWeight = false;
                bool tendencyToLoseWeight = false;
                if (rand.Next(0, 100) <= obese)
                {
                    tendencyToGainWeight = true;

                }
                else if(rand.Next(0,100) <= underweight)
                {
                    tendencyToLoseWeight = true; 
                }

                for (DateTime startdate = new DateTime(2006, 01, 01); startdate.CompareTo(enddate) < 0; startdate = startdate.AddMonths(1))
                {
                    bool addHeight = (rand.Next(3) != 0) ? true : false;
                    if (addHeight == true)
                    {
                        if (height > 65)
                        {
                            addHeight = (rand.Next(4) != 0) ? true : false;
                            if (addHeight == true)
                                height += .3;
                        }
                        else
                            height += .3;
                    }
                    else
                    {
                        if (height < 56)
                        {
                            addHeight = (rand.Next(4) != 0) ? true : false;
                            if (addHeight == true)
                            {
                                height += .3;
                            }
                        }
                    }

                    bool modweight = (BMI <= 34);

                    double addedWeight = rand.Next(0, 6);

                    if (tendencyToGainWeight == true)
                    {
                        if (addedWeight == 6)
                            weight -= .5;
                        else if (modweight == true)
                            weight += addedWeight * .55;
                        else
                        {
                            if (rand.Next(0, 2) == 1)
                                weight += addedWeight * .5;
                            else
                                weight -= addedWeight * .42;
                        }

                    }
                    else if (tendencyToLoseWeight == true)
                    {
                        if (addedWeight >= 5)
                            weight -= addedWeight % 4 * .5;
                        else if (modweight == true)
                            weight += addedWeight * .5;
                        else
                        {
                            if (rand.Next(0, 2) == 1)
                                weight += addedWeight * .5;
                            else
                                weight -= addedWeight * .42;
                        }
                    }
                    else
                    {
                        if (addedWeight >= 5)
                            weight -= addedWeight % 5 * .4;
                        else if (modweight == true)
                            weight += addedWeight * .5;
                        else
                        {
                            if (rand.Next(0, 2) == 1)
                                weight += addedWeight * .5;
                            else
                                weight -= addedWeight * .42;
                        }
                    }

                    if (height >= MaxHeight)
                        height = MaxHeight;

                    if (weight >= MaxWeight)
                        weight = MaxWeight;

                    if (weight < height)
                        weight = height;

                    BMI = CalculateBMI(weight, height);

                    if (BMI > 35 && weight >= oldweight || BMI < 11 && weight <= oldweight)
                    {
                        weight = oldweight;
                        height = oldheight;
                        BMI = CalculateBMI(weight, height);
                    }

                    Hemoglobin = rand.Next(minhemo*2, maxhemo*2);
                    Hemoglobin = Hemoglobin / 2;


                    //write it out here
                    //wright out weight, height, BMI
                    lines.Add("WEIGHT;" + startdate.ToShortDateString() + ";" + weight);
                    lines.Add("HEIGHT;" + startdate.ToShortDateString() + ";" + height);
                    lines.Add("BMI;" + startdate.ToShortDateString() + ";" + BMI );
                    lines.Add("HEMOGLOBIN;" + startdate.ToShortDateString() + ";" + Hemoglobin);
                    
                }

                double hyperRand = rand.Next(0, 1000);
                if (BMI >= overweightBMI)
                {
                    if(hyperRand <= hyperover)
                    {
                        //write out has hypertension
                        lines.Add("HYPERTENSION;" + DateTime.Now.ToShortDateString() + ";TRUE");
                    }
                }
                else
                {
                    if (hyperRand <= hypernormal)
                    {
                        lines.Add("HYPERTENSION;" + DateTime.Now.ToShortDateString()+ ";TRUE");
                        //write out has hypertension
                    }
                }                
            }

            string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(directory + @"\PatientInfo.txt"))
            {
                foreach (string line in lines)
                {
                    file.WriteLine(line);
                }
            }
        }


        public static double CalculateBMI(double weight, double height)
        {

            double weightFactor = .45;
            double heightFactor = .025;

            return (weight * weightFactor) / ((heightFactor* height) * (heightFactor* height));
        }


    }
}
