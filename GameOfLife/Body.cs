using System;
using System.Collections;
using System.Collections.Generic;

namespace GameOfLife
{
    // In this class implemented all process of body.
    class Body : IEnumerable
    {
        public List<Cell> cells = new List<Cell>();
        List<Cell> tempCellAnimate = new List<Cell>();
        List<Cell> tempCellDies = new List<Cell>();
        // Constructor implemented starting living cells
        public Body()
        {
            cells.Add(new Cell() { x = 4, y = 2, });
            cells.Add(new Cell() { x = 4, y = 3, });
            cells.Add(new Cell() { x = 4, y = 4, });
            cells.Add(new Cell() { x = 3, y = 4, });
            cells.Add(new Cell() { x = 2, y = 3, });
        }
        // Methoth define next moment who is die
        public void CellIsDies()
        {
            tempCellDies.Clear();
            foreach (var item in cells)
            {
                int count = 0;
                if (Matrix.arr[item.x, item.y - 1] == 1) { count++; }
                if (Matrix.arr[item.x + 1, item.y - 1] == 1) { count++; }
                if (Matrix.arr[item.x + 1, item.y] == 1) { count++; }
                if (Matrix.arr[item.x + 1, item.y + 1] == 1) { count++; }
                if (Matrix.arr[item.x, item.y + 1] == 1) { count++; }
                if (Matrix.arr[item.x - 1, item.y + 1] == 1) { count++; }
                if (Matrix.arr[item.x - 1, item.y] == 1) { count++; }
                if (Matrix.arr[item.x - 1, item.y - 1] == 1) { count++; }
                if (count != 2 & count != 3) { tempCellDies.Add(item); }
            }
        }
        // Methoth define next moment who is animate
        public void CellIsAnimate()
        {
            tempCellAnimate.Clear();
            for (int i = 0; i < Game.x; i++)
            {
                if (i + 1 >= 25 || i - 1 <= 0) { }
                else
                {
                    for (int j = 0; j < Game.y; j++)
                    {
                        if (j + 1 >= Game.x || j - 1 <= 0) { }
                        else
                        {
                            int count = 0;
                            if (Matrix.arr[i, j - 1] == 1) { count++; }
                            if (Matrix.arr[i + 1, j - 1] == 1) { count++; }
                            if (Matrix.arr[i + 1, j] == 1) { count++; }
                            if (Matrix.arr[i + 1, j + 1] == 1) { count++; }
                            if (Matrix.arr[i, j + 1] == 1) { count++; }
                            if (Matrix.arr[i - 1, j + 1] == 1) { count++; }
                            if (Matrix.arr[i - 1, j] == 1) { count++; }
                            if (Matrix.arr[i - 1, j - 1] == 1) { count++; }
                            if (count == 3) 
                            {
                                tempCellAnimate.Add(new Cell() { x = i, y = j }); 
                            }
                        }
                    }
                }
            } 
        }
        // Accept change data
        public void AcceptChanges()
        {
            foreach (var item in tempCellDies)
            {
                cells.Remove(item);
            }
            foreach (var item in tempCellAnimate)
            {
                bool bo = true;
                
                if(true)
                {
                    foreach (var item1 in cells)
                    { 
                        if(item.x == item1.x & item.y == item1.y) { bo = false; }
                    }
                }
                
                if (bo) 
                {
                    cells.Add(item);
                    bo = true;
                } 
            }
            
        }
        public IEnumerator<Cell> GetEnumerator()
        {
            return cells.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
