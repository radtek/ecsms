using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using ECSMS.Model;
namespace ECSMS.BLL
{
	/// <summary>
	/// EC_SmsChannel
	/// </summary>
	public partial class EC_SmsChannel
	{
		private readonly ECSMS.DAL.EC_SmsChannel dal=new ECSMS.DAL.EC_SmsChannel();
		public EC_SmsChannel()
		{}
		#region  Method
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string Code)
		{
			return dal.Exists(Code);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(ECSMS.Model.EC_SmsChannel model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(ECSMS.Model.EC_SmsChannel model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(string Code)
		{
			
			return dal.Delete(Code);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string Codelist )
		{
			return dal.DeleteList(Codelist );
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public ECSMS.Model.EC_SmsChannel GetModel(string Code)
		{
			
			return dal.GetModel(Code);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ�����
		/// </summary>
		public ECSMS.Model.EC_SmsChannel GetModelByCache(string Code)
		{
			
			string CacheKey = "EC_SmsChannelModel-" + Code;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Code);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (ECSMS.Model.EC_SmsChannel)objModel;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// ���ǰ��������
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<ECSMS.Model.EC_SmsChannel> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<ECSMS.Model.EC_SmsChannel> DataTableToList(DataTable dt)
		{
			List<ECSMS.Model.EC_SmsChannel> modelList = new List<ECSMS.Model.EC_SmsChannel>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ECSMS.Model.EC_SmsChannel model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new ECSMS.Model.EC_SmsChannel();
					model.Code=dt.Rows[n]["Code"].ToString();
					model.Name=dt.Rows[n]["Name"].ToString();
					model.Account=dt.Rows[n]["Account"].ToString();
					model.Pwd=dt.Rows[n]["Pwd"].ToString();
					if(dt.Rows[n]["CorpId"].ToString()!="")
					{
						model.CorpId=int.Parse(dt.Rows[n]["CorpId"].ToString());
					}
					model.ProductCode=dt.Rows[n]["ProductCode"].ToString();
					model.OtherPara=dt.Rows[n]["OtherPara"].ToString();
					if(dt.Rows[n]["TotalNum"].ToString()!="")
					{
						model.TotalNum=int.Parse(dt.Rows[n]["TotalNum"].ToString());
					}
					if(dt.Rows[n]["MaxSendNum"].ToString()!="")
					{
						model.MaxSendNum=int.Parse(dt.Rows[n]["MaxSendNum"].ToString());
					}
					if(dt.Rows[n]["AwokeNum"].ToString()!="")
					{
						model.AwokeNum=int.Parse(dt.Rows[n]["AwokeNum"].ToString());
					}
					if(dt.Rows[n]["State"].ToString()!="")
					{
						model.State=int.Parse(dt.Rows[n]["State"].ToString());
					}
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method
	}
}

