using System;
namespace ECSMS.Model
{
	/// <summary>
	/// EC_SmsSp:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public partial class EC_SmsSp
	{
		public EC_SmsSp()
		{}
		#region Model
		private int _id;
		private string _name;
		private int? _limit;
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
		public int? Limit
		{
			set{ _limit=value;}
			get{return _limit;}
		}
		#endregion Model

	}
}

