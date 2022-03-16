using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Utility.Results.Abstract
{
    public interface IDataResult<out T>:IResult
    {
        //Out örn category tek te taşınabilir liste ile de taşınabilir.
        public T Data { get;} //new DataResult<Category>(ResultStatus.Success,category);
                              //new DataResult<IList<Category>>(ResultStatus.Success,categoryList);
    }
}
