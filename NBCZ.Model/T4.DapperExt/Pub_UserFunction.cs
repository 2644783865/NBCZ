
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由T4模板自动生成
//	   生成时间 2018-05-14 10:47:05
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失
//     作者：Harbour
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using DapperExtensions.Mapper;
namespace NBCZ.Model
{

    public partial class Pub_UserFunction
    {

       
		
		/// <summary>
		/// 
		/// </summary>		
		public int Id { get; set; }
		
		/// <summary>
		/// 用户编号
		/// </summary>		
		public string UserCode { get; set; }
		
		/// <summary>
		/// 权限编号
		/// </summary>		
		public string FunctionCode { get; set; }
		
		/// <summary>
		/// 最后编辑人
		/// </summary>		
		public string Lmid { get; set; }
		
		/// <summary>
		/// 最后编辑时间
		/// </summary>		
		public DateTime? Lmdt { get; set; }
		
		/// <summary>
		/// 停用状态 默认0 未停用 1 停用
		/// </summary>		
		public bool? StopFlag { get; set; }
		   
    }
}

