
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由T4模板自动生成
//	   生成时间 2018-04-13 08:53:05
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失
//     作者：Harbour CTS
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using NBCZ.Model;
using NBCZ.DAL;

namespace NBCZ.BLL
{	
	public partial class Pub_RoleFunctionBLL:BaseService<Model.Pub_RoleFunction>
    {
        /// 删除一条数据
        /// </summary>
        public bool DeleteByPrimaryKey(int  Id)
        {
               var newClass = new
			   {
			         Id = Id   
			   };   
            return base.DeleteByWhere("Id=@Id", newClass);
        }

    }
}

