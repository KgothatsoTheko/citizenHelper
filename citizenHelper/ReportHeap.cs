//ST10092141 - Kgothatso Theko
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citizenHelper
{
    //Heap for Optimizing Display - prioritize reports based on certain criteria, such as urgency or submission time, optimizing the display order.
    // Max Heap Implementation Based on Submission Time adapted from GeeksForGeeks
    //https://www.geeksforgeeks.org/convert-bst-to-max-heap/
    public class ReportHeap
    {
        private List<ReportData> _heap;
        private Comparison<ReportData> _comparison;

        public ReportHeap(Comparison<ReportData> comparison)
        {
            _heap = new List<ReportData>();
            _comparison = comparison;
        }

        public void Insert(ReportData report)
        {
            _heap.Add(report);
            HeapifyUp(_heap.Count - 1);
        }

        public ReportData ExtractTop()
        {
            if (_heap.Count == 0)
                throw new InvalidOperationException("Heap is empty.");

            ReportData top = _heap[0];
            _heap[0] = _heap[_heap.Count - 1];
            _heap.RemoveAt(_heap.Count - 1);
            HeapifyDown(0);
            return top;
        }

        public ReportData Peek()
        {
            if (_heap.Count == 0)
                throw new InvalidOperationException("Heap is empty.");
            return _heap[0];
        }

        public int Count => _heap.Count;

        private void HeapifyUp(int index)
        {
            while (index > 0)
            {
                int parent = (index - 1) / 2;
                if (_comparison(_heap[index], _heap[parent]) > 0)
                {
                    Swap(index, parent);
                    index = parent;
                }
                else
                    break;
            }
        }

        private void HeapifyDown(int index)
        {
            int lastIndex = _heap.Count - 1;
            while (true)
            {
                int left = 2 * index + 1;
                int right = 2 * index + 2;
                int largest = index;

                if (left <= lastIndex && _comparison(_heap[left], _heap[largest]) > 0)
                    largest = left;

                if (right <= lastIndex && _comparison(_heap[right], _heap[largest]) > 0)
                    largest = right;

                if (largest != index)
                {
                    Swap(index, largest);
                    index = largest;
                }
                else
                    break;
            }
        }

        private void Swap(int i, int j)
        {
            var temp = _heap[i];
            _heap[i] = _heap[j];
            _heap[j] = temp;
        }
    }
}
