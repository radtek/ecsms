using System;
namespace ECSMS.Model
{
	/// <summary>
	/// EC_AutoPay:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public partial class EC_AutoPay
	{
		public EC_AutoPay()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _account;
		private decimal? _userid;
		private string _userkey;
		private string _expenses;
		private int? _enabled;
		private int? _postuser;
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
		public string Account
		{
			set{ _account=value;}
			get{return _account;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserKey
		{
			set{ _userkey=value;}
			get{return _userkey;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Expenses
		{
			set{ _expenses=value;}
			get{return _expenses;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Enabled
		{
			set{ _enabled=value;}
			get{return _enabled;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PostUser
		{
			set{ _postuser=value;}
			get{return _postuser;}
		}
		#endregion Model

	}
}

