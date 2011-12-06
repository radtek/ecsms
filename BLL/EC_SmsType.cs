using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using ECSMS.Model;
namespace ECSMS.BLL
{
	/// <summary>
	/// EC_SmsType
	/// </summary>
	public partial class EC_SmsType
	{
		private readonly ECSMS.DAL.EC_SmsType dal=new ECSMS.DAL.EC_SmsType();
		public EC_SmsType()
		{}
		#region  Method
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string Type)
		{
			return dal.Exists(Type);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(ECSMS.Model.EC_SmsType model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(ECSMS.Model.EC_SmsType model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(string Type)
		{
			
			return dal.Delete(Type);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string Typelist )
		{
			return dal.DeleteList(Typelist );
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public ECSMS.Model.EC_SmsType GetModel(string Type)
		{
			
			return dal.GetModel(Type);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ�����
		/// </summary>
		public ECSMS.Model.EC_SmsType GetModelByCache(string Type)
		{
			
			string CacheKey = "EC_SmsTypeModel-" + Type;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Type);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (ECSMS.Model.EC_SmsType)objModel;
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
		public List<ECSMS.Model.EC_SmsType> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<ECSMS.Model.EC_SmsType> DataTableToList(DataTable dt)
		{
			List<ECSMS.Model.EC_SmsType> modelList = new List<ECSMS.Model.EC_SmsType>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ECSMS.Model.EC_SmsType model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new ECSMS.Model.EC_SmsType();
					model.Type=dt.Rows[n]["Type"].ToString();
					model.Name=dt.Rows[n]["Name"].ToString();
					model.Remark=dt.Rows[n]["Remark"].ToString();
					model.ChannelCode=dt.Rows[n]["ChannelCode"].ToString();
					model.Price=dt.Rows[n]["Price"].ToString();
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

