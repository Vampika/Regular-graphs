using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectedGraph
{
    /// <summary>
    /// Класс, работающий с уже сгенерированными регулярными графами
    /// </summary>
    public class ConnectedGraphs
    {
        /// <summary>
        /// Список графов
        /// </summary>
        private List<int[,]> graphs;

        public List<int[,]> Graphs
        {
            get
            {
                return this.graphs;
            }
        }

        /// <summary>
        /// Список матриц кратчайших расстояний графов
        /// </summary>
        private List<int[,]> ShortedDistance;

        /// <summary>
        /// Массив диаметров графов
        /// </summary>
        private int[] diameter;

        public int[] Diameter
        {
            get
            {
                return this.diameter;
            }
        }

        /// <summary>
        /// Количество вершин
        /// </summary>
        private int nodeCount;

        /// <summary>
        /// Массив для хранения информации о пройденных или не пройденных вершинах
        /// </summary>
        bool[] used;

        int Count = 0;

        public ConnectedGraphs(List<int[,]> Input, int nodeCount)
        {
            this.graphs = Input;
            this.nodeCount = nodeCount;
            used = new bool[nodeCount];
            for (int i = 0; i < nodeCount; i++)
                used[i] = false;
        }

        /// <summary>
        /// Обход графа в глубину
        /// </summary>
        /// <param name="v">Начальная вершика обхода</param>
        /// <param name="InputGraph">Марица смежности графа</param>
        void dfs(int v, int[,] InputGraph)
        {
            //если вершина уже пройдена, то выходим
            if (used[v])
            {
                return;
            }
            used[v] = true; //Помечаем вершину как пройденную
            Count++;
            for (int i = 0; i < nodeCount; i++)
            {
                if(InputGraph[v, i]==1)
                    dfs(i, InputGraph);
            }
        }

        /// <summary>
        /// Проверка графа на связность
        /// </summary>
        /// <param name="Input">Матрица смежности графа</param>
        /// <returns>true - несвязный, false - связный</returns>
        private bool IsGraphConnected(int[,] Input)
        {
                Count = 0;
                for (int i = 0; i < nodeCount; i++)
                 used[i] = false;
                dfs(0, Input);
                if (Count == nodeCount)
                    return false;
            return true;
         }

        /// <summary>
        /// удаление несвязных графов
        /// </summary>
        public void deleteNotConnected()
        {
            for(int i=0;i<this.graphs.Count;i++)
            {
                if (IsGraphConnected(this.graphs[i]))
                {
                    this.graphs.RemoveAt(i);
                    i--;
                }
            }
        }

        /// <summary>
        /// Поиск меньшего из двух чисел
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        /// <returns>Возвращает  меньшее из двух чисел</returns>
        private int min(int a, int b)
        {
            if (a < b) return a;
            else return b;
        }

        /// <summary>
        /// Поиск матрицы длин кратчайших расстояний между вершинами
        /// Алгоритмом Флойда-Уоршалла
        /// </summary>
        /// <param name="Input">Матрица смежности графа</param>
        /// <returns>Возвращает матрицу кратчайших расстояний</returns>
        private int[,] FloydWarshall(int[,] Input)
        {
            int[,] d = new int[nodeCount, nodeCount];
            for (int i = 0; i < nodeCount; i++)
            {
                for (int j = 0; j < nodeCount; j++)
                {
                    if (i != j)
                    {
                        if (Input[i,j] == 0)
                            d[i,j] = 100;
                        else d[i,j] = 1;
                    }
                    else d[i,j] = Input[i,j];
                }
             }

            for (int k = 0; k < nodeCount; ++k)
                for (int i = 0; i < nodeCount; ++i)
                    for (int j = 0; j < nodeCount; ++j)
                        d[i,j] = min(d[i,j], d[i,k] + d[k,j]);

            return d;
        }

        /// <summary>
        /// Поиск максимального элемента в матрице расстояний
        /// </summary>
        /// <param name="">Матрица расстояний</param>
        /// <returns>Возвращает максимальное значение расстояния</returns>
        private int MaxDistance(int[,] Input)
        {
            int Result = Input[0, 0];
            for(int i=0; i<nodeCount; i++)
            {
                for(int j=0; j<nodeCount; j++)
                {
                    if (Input[i,j] > Result)
                    {
                        Result = Input[i, j];
                    }
                }
            }
            return Result;
        }

        /// <summary>
        /// Расчет диаметров графов
        /// </summary>
        public void CalculateDiameters()
        {
            this.ShortedDistance = new List<int[,]>();
            this.diameter = new int[this.graphs.Count];

            for(int i=0; i<this.graphs.Count; i++)
            {
                this.ShortedDistance.Add(FloydWarshall(Graphs[i]));
                diameter[i] = MaxDistance(ShortedDistance[i]);
            }
        }

        public string PrintResult()
        {
            
            string str = "";
            for (int i = 0; i < this.graphs.Count; i++)
            {
                str += (i + 1).ToString() + ") Диаметр графа: " + diameter[i].ToString() + Environment.NewLine + Environment.NewLine;
                for (int j = 0; j < nodeCount; j++)
                {
                    ///////////////////////////////////
                    ///// ОТСТУП ПЕРЕД ВЫВОДОМ ////////
                    ///////////////////////////////////
                    str += "    ";

                    for (int k = 0; k < nodeCount; k++)
                    {
                        str += (this.graphs[i][j, k]).ToString();
                    }
                    str += Environment.NewLine;
                }
                str += Environment.NewLine;
                str += Environment.NewLine;
                str += Environment.NewLine;
            }
            return str;
        }
    }
}
