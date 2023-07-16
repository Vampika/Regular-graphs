using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenegationRegular
{
    /// <summary>
    /// Класс, генерирующий регулярные графы
    /// </summary>
    public class Generator
    {
        /// <summary>
        /// Количество вершин
        /// </summary>
        int nodeCount;

        public int NodeCount
        {
            get
            {
                return this.nodeCount;
            }
        }

        /// <summary>
        /// Связность вершин
        /// </summary>
        int connectivity;

        /// <summary>
        /// Список сгенерированных графов
        /// </summary>
        public List<int[,]> Grapth;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nodeCount">Количество вершин</param>
        /// <param name="connectivity">Связность вершин</param>
        public Generator(int nodeCount, int connectivity)
        {
            this.nodeCount = nodeCount;
            this.connectivity = connectivity;
            this.Grapth = new List<int[,]>();
        }

        /// <summary>
        /// Декодирование
        /// </summary>
        /// <param name="Input">Массив (двоичное рпедставление числа)</param>
        /// <returns>Возвращает число в десятичной системе счислеяни</returns>
        private long deCode(int[] Input)
        {
            long Result = 0;
            for(int i=0; i<nodeCount; i++)
            {
                Result += (long)(Input[nodeCount - 1 - i] * Math.Pow(2, i));
            }

            return Result;
        }

        /// <summary>
        /// Кодирование
        /// </summary>
        /// <param name="Input">Число в десятичной системе счисления</param>
        /// <returns>Возвращает массив - число в двоичной системе счиления</returns>
        private int[] Code (long Input)
        {
            int[] Result = new int[nodeCount];
            for(int i=0; i<nodeCount; i++)
            {
                Result[nodeCount - 1 - i] = (int)Input % 2;
                Input = (long)(Input / 2);
            }

            return Result;
        }

        /// <summary>
        /// Подсчет суммы битов
        /// </summary>
        /// <param name="Input">Массив (Двоичное представление числа)</param>
        /// <returns>Возвращает сумму битов</returns>
        private int CalcConnect(int[] Input)
        {
            int Result = 0;
            for(int i=0; i<Input.Length; i++)
            {
                Result += Input[i];
            }

            return Result;
        }

        /// <summary>
        /// Расчет максимального значения генерации
        /// </summary>
        /// <returns>Возвращает максимальное значение генерации</returns>
        private long MinValue()
        {
            int[] Result = new int[nodeCount]; 
            for(int i=0; i<connectivity; i++)
            {
                Result[nodeCount - 1 - i] = 1;
            }

            return deCode(Result);
        }

        /// <summary>
        /// Расчет минимального значения генерации
        /// </summary>
        /// <returns>Возвращает минимальное значение генерации</returns>
        private long MaxValue()
        {
            int[] Result = new int[nodeCount];
            for (int i = 0; i < connectivity; i++)
            {
                Result[i] = 1;
            }

            return deCode(Result);
        }

        /// <summary>
        /// Генерация двоичных строк
        /// </summary>
        /// <returns>Возвращает список строк</returns>
        private List<int[]> generate()
        {
            List<int[]> Result = new List<int[]>();
            int[] cod = new int[nodeCount];
            for (long i = MinValue(); i<MaxValue()+1; i++)
            {
                cod = Code(i);
                if (CalcConnect(cod) == connectivity)
                    Result.Add(cod);
            }

            return Result;
        }
        /// <summary>
        /// Вывод результата генерации строк
        /// </summary>
        /// <param name="Input"></param>
        /// <returns></returns>
        public string PrintResult(List<int[,]> Input)
        {
            string str = "";
            for (int i = 0; i < Input.Count; i++)
            {
                str += (i+1).ToString()+")"+Environment.NewLine;
                for (int j = 0; j < nodeCount; j++)
                {
                    ///////////////////////////////////
                    ///// ОТСТУП ПЕРЕД ВЫВОДОМ ////////
                    ///////////////////////////////////
                        str += "    ";
                    
                    for (int k = 0; k < nodeCount; k++)
                    {
                        str += (Input[i][j,k]).ToString();
                    }
                    str += Environment.NewLine;
                }
                str += Environment.NewLine;
                str += Environment.NewLine;
            }
            return str;
        }

        /// <summary>
        /// Отсеивание ненужных матриц
        /// </summary>
        /// <param name="Input"></param>
        /// <returns></returns>
        private List<int[,]> SearchForSuitable(List<int[,]> Input)
        {
            bool flag=true;
            List<int[,]> Result = new List<int[,]>();
            //проверка на симметричность
            for (int z = 0; z < Input.Count; z++)
            {
                {
                    for (int i = 0; i < nodeCount; i++)
                        for (int j = 0; j < nodeCount; j++)
                        {
                            if (Input[z][i, j] != Input[z][j, i])
                                flag = false;
                        }
                }
                if (flag == true)
                    Result.Add(Input[z]);
                flag = true;
            }
            //Проверка на 1 по диагонали
            flag = true;
            for (int z = 0; z < Result.Count; z++)
            { for (int i = 0; i < nodeCount; i++)
                { for (int j = 0; j < nodeCount; j++)
                        if (i == j)
                        { if(Result[z][i, j] != 0)
                            flag = false;
                        }
                }
                if (flag == false)
                    Result.RemoveAt(z);
                flag = true;
            }
            return Result;
        }
        
        /// <summary>
        /// Проверка, является ли матрица графом
        /// </summary>
        /// <param name="Matrix">Проверяемая матрица</param>
        /// <returns>true - матрица является графом, иначе false</returns>
        private bool IsItGrath (int[,] Matrix)
        {
            //Проверка на наличие 1 на диагонали
            for (int i = 0; i < nodeCount; i++)
            {
                for (int j = 0; j < nodeCount; j++)
                {
                    if (i == j)
                    {
                        if (Matrix[i, j] != 0)
                            return false;
                    }
                }
            }

            //проверка на симметричность

            for (int i = 0; i < nodeCount; i++)
            {
                for (int j = 0; j < nodeCount; j++)
                {
                    if (Matrix[i, j] != Matrix[j, i])
                        return false;
                }
            }

            return true;              
         }

        /// <summary>
        /// Добавление графа в список графов
        /// </summary>
        /// <param name="InputRows">Список сгенерированных строк</param>
        /// <param name="InputIndex">Массив индексов строк</param>
        private void RegularGenerate(List<int[]> InputRows, int[] InputIndex)
        {
            List<int[]> Rows = InputRows;
            int[] Index = InputIndex;
            int[,] Matrix = new int[nodeCount, nodeCount];

            for (int i = 0; i < nodeCount; i++)
            {
                for (int k = 0; k < nodeCount; k++)
                {
                    Matrix[i, k] = Rows[Index[i]][k];
                }
            }

            if (IsItGrath(Matrix))
            {
                Grapth.Add(new int[nodeCount, nodeCount]);
                for (int i = 0; i < nodeCount; i++)
                {
                    for (int k = 0; k < nodeCount; k++)
                    {
                        Grapth[Grapth.Count - 1][i, k] = Matrix[i, k];
                    }
                }
            }
        }

        /// <summary>
        /// Генерация Регулярных графов
        /// </summary>
        /// <returns></returns>
        public void GrathGenerate()
        {
            int size = this.nodeCount;
            int[] arr = new int[size];
            List<int[]> Rows = generate();
            int maxValue = Rows.Count-1;

            while (true)
            {
                RegularGenerate(Rows, arr);

                int i = size - 1;

                while (arr[i] == maxValue)
                {
                    arr[i] = 0;
                    i--;
                    if (i < 0) break;
                }
                if (i < 0) break;
                arr[i]++;
            }
        }
        
    }
}
