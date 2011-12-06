using System;
namespace ECSMS.Model
{
	/// <summary>
	/// EC_ProChannel:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public partial class EC_ProChannel
	{
		public EC_ProChannel()
		{}
		#region Model
		private int _id;
		private string _procode;
		private string _spcode;
		private string _channel;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProCode
		{
			set{ _procode=value;}
			get{return _procode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SpCode
		{
			set{ _spcode=value;}
			get{return _spcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Channel
		{
			set{ _channel=value;}
			get{return _channel;}
		}
		#endregion Model

	}
}

