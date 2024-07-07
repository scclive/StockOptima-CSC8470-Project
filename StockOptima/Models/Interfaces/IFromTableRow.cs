using System.Collections.Generic;

namespace StockOptima.Models.Interfaces
{
    public interface IFromTableRow
    {
        void FromTableRow(Dictionary<string, string> row);
    }
}