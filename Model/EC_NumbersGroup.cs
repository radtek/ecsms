using System;
namespace ECSMS.Model
{
	/// <summary>
	/// EC_NumbersGroup:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class EC_NumbersGroup
	{
		public EC_NumbersGroup()
		{}
		#region Model
		private int _id;
		private string _name;
		private int? _parentid;
		private string _userid;
		private int? _price;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ParentId
		{
			set{ _parentid=value;}
			get{return _parentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		#endregion Model

	}
}

