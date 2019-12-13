using System;
using System.Collections.Generic;
using System.Text;

namespace Labyrinth
{
    public class Entity
    {
        public int EntityPositionColumn { get; set; }
        public int EntityPositionRow { get; set; }
        public char EntityChar { get; set; }
        public string MoveHorizonMapLine (int columnNum, string row, bool toRight)
        {
            char[] rowArray = row.ToCharArray();
            char[] area = { EntityChar, ' ' };
            if (toRight == true)
            {
                rowArray[columnNum - 1] = area[1];
                rowArray[columnNum] = area[0];
            }
            else if (toRight == false)
            {
                rowArray[columnNum + 1] = area[1];
                rowArray[columnNum] = area[0];
            }
            row = new string(rowArray);
            return row;
        }
        
    }
}
