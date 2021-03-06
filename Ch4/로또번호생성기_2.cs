﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4
{
    class 로또번호생성기_2
    {
        static void Main(string[] args)
        {
            Random lotto = new Random();
            int[] result = new int[6];

            for (int k = 0; k < 50; k++) //로또번호 20줄 생성
            {
                for (int i = 0; i < 6; i++) //로또번호 한줄 생성
                {
                    int temp = lotto.Next(1, 46);

                    result[i] = temp;

                    for (int j = 0; j < i; j++) //중복숫자 제거
                        if (result[j] == temp)
                            i--;
                }

                for (int i = 0; i < result.Length; i++) //로또번호 정렬
                {
                    for (int j = 0; j < result.Length - i - 1; j++)
                    {
                        int temp;

                        if (result[j] > result[j+1])
                        {
                            temp = result[j+1];
                            result[j+1] = result[j];
                            result[j] = temp;
                        }
                    }
                }

                for (int i = 0; i < result.Length; i++) //로또번호 출력
                    Console.Write("{0:D2} ", result[i]);

                Console.WriteLine();
            }
        }
    }
}
