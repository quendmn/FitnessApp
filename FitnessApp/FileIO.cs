using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessApp
{
    internal class FileIO
    {
        public FileIO() { }

        public int SaveData(string filename = "data.txt")
        {
            StreamReader sr = new StreamReader(filename);
            string lines = sr.ReadToEnd();
            if (lines.Contains(DateTime.Now.ToString("dd.MM.yyyy, dddd")))
            {
                sr.Close();
                return 0;
            }
            else
            {
                StreamWriter sw = new StreamWriter(filename, true);
                sw.WriteLine(DateTime.Now.ToString("dd.MM.yyyy, dddd") + " - " + GetTotalCalories() + " ккал");
                sw.Close();
                return 0;
            }       
        }
        public void ClearData()
        { 
            File.WriteAllText("breakfast.txt", string.Empty);
            File.WriteAllText("lunch.txt", string.Empty);
            File.WriteAllText("dinner.txt", string.Empty);
            File.WriteAllText("other.txt", string.Empty);
            
        }
        public int ChangeCalories()
        {
            string[] lines = File.ReadAllLines("calories.txt");
            if(lines.Length == 0)
            {
                int calories = 1800;
                return calories;
            }
            else
            {
                StreamReader sr = new StreamReader("calories.txt");
                int calories = int.Parse(sr.ReadLine());
                sr.Close();
                return calories;
            }

        }

        public string[] GetData(string filename)
        {
            string[] lines = File.ReadAllLines(filename); 
            return lines;
        }

        // завтрак
       public void WriteBreakfastData(BreakfastForm breakfastForm, string filename = "breakfast.txt")
        {
            StreamReader sr = new StreamReader(filename);
            string lines = sr.ReadToEnd();
            if (lines.Contains(breakfastForm.GetProduct()))
            {
                sr.Close();

                int calories = GetProductCalories(filename, breakfastForm.GetProduct());
                int weight = GetProductWeight(filename, breakfastForm.GetProduct());

                DeleteProduct(breakfastForm.GetProduct(), filename);

                StreamWriter sw_1 = new StreamWriter(filename, true);
                sw_1.Write(("— " + breakfastForm.GetProduct() + ", " +
                (breakfastForm.GetWeight() + weight) + " гр, " + (breakfastForm.CountCalories() + calories)
                + " ккал\n"));

                sw_1.Close();
 

            }
            else
            {
                sr.Close();
                StreamWriter sw = new StreamWriter(filename, true);
                if (breakfastForm.GetProduct() != null && breakfastForm.GetWeight() != 0
                    && breakfastForm.CountCalories() != 0)
                {
                    sw.Write(("— " + breakfastForm.GetProduct() + ", " +
                    breakfastForm.GetWeight() + " гр, " + breakfastForm.CountCalories() + " ккал\n"));
                    sw.Close();
                }
                else
                {
                    sw.Close();
                }
            }
            sr.Close();
        }

        // обед
        public void WriteLunchData(LunchForm lunchForm, string filename = "lunch.txt")
        {
            StreamReader sr = new StreamReader(filename);
            string lines = sr.ReadToEnd();
            if (lines.Contains(lunchForm.GetProduct()))
            {
                sr.Close();

                int calories = GetProductCalories(filename, lunchForm.GetProduct());
                int weight = GetProductWeight(filename, lunchForm.GetProduct());

                DeleteProduct(lunchForm.GetProduct(), filename);

                StreamWriter sw_1 = new StreamWriter(filename, true);
                sw_1.Write(("— " + lunchForm.GetProduct() + ", " +
                (lunchForm.GetWeight() + weight) + " гр, " + (lunchForm.CountCalories() + calories)
                + " ккал\n"));

                sw_1.Close();

                

            }
            else
            {
                sr.Close();
                StreamWriter sw = new StreamWriter(filename, true);
                if (lunchForm.GetProduct() != null && lunchForm.GetWeight() != 0
                    && lunchForm.CountCalories() != 0)
                {
                    sw.Write(("— " + lunchForm.GetProduct() + ", " +
                    lunchForm.GetWeight() + " гр, " + lunchForm.CountCalories() + " ккал\n"));
                    sw.Close();
                }
                else
                {
                    sw.Close();
                }
            }
            sr.Close();

        }

        // ужин
        public void WriteDinnerData(DinnerForm dinnerForm, string filename = "dinner.txt")
        {
            StreamReader sr = new StreamReader(filename);
            string lines = sr.ReadToEnd();
            if (lines.Contains(dinnerForm.GetProduct()))
            {
                sr.Close();

                int calories = GetProductCalories(filename, dinnerForm.GetProduct());
                int weight = GetProductWeight(filename, dinnerForm.GetProduct());

                DeleteProduct(filename, dinnerForm.GetProduct());

                StreamWriter sw_1 = new StreamWriter(filename, true);
                sw_1.Write(("— " + dinnerForm.GetProduct() + ", " +
                (dinnerForm.GetWeight() + weight) + " гр, " + (dinnerForm.CountCalories() + calories)
                + " ккал\n"));

                sw_1.Close();

                

            }
            else
            {
                sr.Close();
                StreamWriter sw = new StreamWriter(filename, true);
                if (dinnerForm.GetProduct() != null && dinnerForm.GetWeight() != 0
                    && dinnerForm.CountCalories() != 0)
                {
                    sw.Write(("— " + dinnerForm.GetProduct() + ", " +
                    dinnerForm.GetWeight() + " гр, " + dinnerForm.CountCalories() + " ккал\n"));
                    sw.Close();
                }
                else
                {
                    sw.Close();
                }
            }
            sr.Close();

        }

        // другое
        public void WriteOtherData(OtherForm otherForm, string filename = "other.txt")
        {
            StreamReader sr = new StreamReader(filename);
            string lines = sr.ReadToEnd();
            if (lines.Contains(otherForm.GetProduct()))
            {
                sr.Close();

                int calories = GetProductCalories(filename, otherForm.GetProduct());
                int weight = GetProductWeight(filename, otherForm.GetProduct());

                DeleteProduct(filename, otherForm.GetProduct());

                StreamWriter sw_1 = new StreamWriter(filename, true);
                sw_1.Write(("— " + otherForm.GetProduct() + ", " +
                (otherForm.GetWeight() + weight) + " гр, " + (otherForm.CountCalories() + calories)
                + " ккал\n"));

                sw_1.Close();

                

            }
            else
            {
                sr.Close();
                StreamWriter sw = new StreamWriter(filename, true);
                if (otherForm.GetProduct() != null && otherForm.GetWeight() != 0
                    && otherForm.CountCalories() != 0)
                {
                    sw.Write(("— " + otherForm.GetProduct() + ", " +
                    otherForm.GetWeight() + " гр, " + otherForm.CountCalories() + " ккал\n"));
                    sw.Close();
                }
                else
                {
                    sw.Close();
                }
            }
            sr.Close();

        }

        public string GetCaloriesString(string filename)
        {
            int calories = 0;
            StreamReader f = new StreamReader(filename);
            while (!f.EndOfStream)
            {
                int counter = 0;
                string s = f.ReadLine();
                string[] words = s.Split(Convert.ToChar(" "));

                foreach (var item in words)
                {
                    counter++;
                    if (counter == 5)
                    {
                        counter = 0;
                        calories += int.Parse(item);
                    }
                }
            }
            f.Close();
            return Convert.ToString(calories);
        }

        public int GetCaloriesInt(string filename)
        {
            int calories = 0;
            StreamReader f = new StreamReader(filename);
            while (!f.EndOfStream)
            {
                int counter = 0;
                string s = f.ReadLine();
                string[] words = s.Split(Convert.ToChar(" "));

                foreach (var item in words)
                {
                    counter++;
                    if (counter == 5)
                    {
                        counter = 0;
                        calories += int.Parse(item);
                    }
                }
            }
            f.Close();
            return calories;
        }

        public int GetProductCalories(string filename, string product)
        {           
            StreamReader f = new StreamReader(filename);
            while (!f.EndOfStream)
            {
                int counter = 0;
                string s = f.ReadLine();
                string[] words = s.Split(Convert.ToChar(" "));

                for (int i = 0; i < words.Length; i++)
                {
                    counter++;
                    if (counter == 2)
                    {
                        if (words[i] == (product + ","))
                        {
                            f.Close();
                            return int.Parse(words[4]);
                        }
                    }
                }
            }
            f.Close();
            return 0;
        }

        public int GetProductWeight(string filename, string product)
        {
            string calories = "";
            StreamReader f = new StreamReader(filename);
            while (!f.EndOfStream)
            {
                int counter = 0;
                string s = f.ReadLine();
                string[] words = s.Split(Convert.ToChar(" "));

                for (int i = 0; i < words.Length; i++)
                {
                    counter++;
                    if (counter == 2)
                    {
                        if (words[i] == (product + ","))
                        {
                            f.Close();
                            return int.Parse(words[2]);

                        }
                    }
                }
            }
            f.Close();
            return 0;
        }

        public string GetTotalCalories()
        {
            int calories = GetCaloriesInt("breakfast.txt") + GetCaloriesInt("lunch.txt") +
                GetCaloriesInt("dinner.txt") + GetCaloriesInt("other.txt");
            return Convert.ToString(calories);
        }

        public int AddProduct(string product, string filename = "products.txt")
        {                                    
            StreamReader sr = new StreamReader(filename);
            string lines = sr.ReadToEnd();
            if (lines.Contains(product))
            {
                sr.Close();
                return 0;
            }
            else {
                sr.Close();
                StreamWriter sw = new StreamWriter(filename, true);
                sw.WriteLine(product);
                sw.Close();  
                return 0;
            }
            
        }

        public void DeleteProduct(string product, string filename = "products.txt")
        {
            string strSearchText = product;
            string strOldText;
            string n = "";
            StreamReader sr = File.OpenText(filename);
            while ((strOldText = sr.ReadLine()) != null)
            {
                if (!strOldText.Contains(strSearchText))
                {
                    n += strOldText + Environment.NewLine;
                }
            }
            sr.Close();
            File.WriteAllText(filename, n);
        }


    }
}
