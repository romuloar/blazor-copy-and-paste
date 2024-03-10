using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyPaste.Infra.Excel
{
    public interface IExcelContentParser
    {
        String ValidMimeType { get; }
        public Boolean CanParse(String mimeType) => ValidMimeType.Equals(mimeType, StringComparison.InvariantCultureIgnoreCase);
        Task<IList<String[]>> GetRows(String input);
    }
}
