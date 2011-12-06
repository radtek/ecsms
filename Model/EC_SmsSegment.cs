using System;
namespace ECSMS.Model
{
	/// <summary>
	/// EC_SmsSegment:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public partial class EC_SmsSegment
	{
		public EC_SmsSegment()
		{}
		#region Model
		private int _id;
		private int? _spid;
		private string _segment;
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
		public int? SpId
		{
			set{ _spid=value;}
			get{return _spid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Segment
		{
			set{ _segment=value;}
			get{return _segment;}
		}
		#endregion Model

	}
}

