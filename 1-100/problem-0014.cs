﻿using System;
using System.Collections.Generic;

namespace proj_euler
{
    internal class P14
    {
        public static void Run()
        {
            int maxSeq = 0;
            int maxSeqNum = 1;
            Dictionary<long, int> memo = new(); 

            for (int i = 1; i < 1000000; i++)
            {
                long seq = i;
                int seqCount = 0;

                while (seq != 1)
                {
                    if (memo.ContainsKey(seq)) 
                    {
                        seqCount += memo[seq];
                        break;
                    }

                    if (seq % 2 == 0)
                        seq = seq / 2;

                    else
                        seq = (3 * seq) + 1;

                    seqCount++;
                }

                memo[i] = seqCount; 

                if (seqCount > maxSeq)
                {
                    maxSeq = seqCount;
                    maxSeqNum = i;
                }
            }

            Console.WriteLine(maxSeqNum);
        }
    }
}
