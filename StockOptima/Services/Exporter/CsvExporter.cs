using System.Text;
using StockOptima.Models.Interfaces;
using StockOptima.Services.Database;

namespace StockOptima.Services.Exporter
{
    public class CsvExporter<T> : ExporterService where T : class, IIdBasedModel, IToTableRow, ITableHeaders
    {
        private readonly DatabaseService<T> _databaseService;

        public CsvExporter(DatabaseService<T> databaseService)
        {
            _databaseService = databaseService;
        }

        public override string ContentType => "text/csv";
        public override string FileExtension => "csv";

        public override byte[] Export()
        {
            StringBuilder builder = new();
            bool firstTime = true;

            foreach (T model in _databaseService.GetAll())
            {
                if (firstTime)
                {
                    firstTime = false;
                    builder.AppendJoin(',', model.TableHeaders).AppendLine();
                }

                builder.AppendJoin(',', model.ToTableRow()).AppendLine();
            }

            return EncodeUtf8(builder.ToString());
        }
    }
}