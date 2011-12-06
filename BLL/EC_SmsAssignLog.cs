using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using ECSMS.Model;
namespace ECSMS.BLL
{
	/// <summary>
	/// EC_SmsAssignLog
	/// </summary>
	public partial class EC_SmsAssignLog
	{
		private readonly ECSMS.DAL.EC_SmsAssignLog dal=new ECSMS.DAL.EC_SmsAssignLog();
		public EC_SmsAssignLog()
		{}
		#region  Method

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int Id)
		{
			return dal.Exists(Id);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(ECSMS.Model.EC_SmsAssignLog model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(ECSMS.Model.EC_SmsAssignLog model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int Id)
		{
			
			return dal.Delete(Id);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			return dal.DeleteList(Idlist );
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public ECSMS.Model.EC_SmsAssignLog GetModel(int Id)
		{
			
			return dal.GetModel(Id);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ�����
		/// </summary>
		public ECSMS.Model.EC_SmsAssignLog GetModelByCache(int Id)
		{
			
			string CacheKey = "EC_SmsAssignLogModel-" + Id;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Id);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (ECSMS.Model.EC_SmsAssignLog)objModel;
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
		public List<ECSMS.Model.EC_SmsAssignLog> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<ECSMS.Model.EC_SmsAssignLog> DataTableToList(DataTable dt)
		{
			List<ECSMS.Model.EC_SmsAssignLog> modelList = new List<ECSMS.Model.EC_SmsAssignLog>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ECSMS.Model.EC_SmsAssignLog model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new ECSMS.Model.EC_SmsAssignLog();
					if(dt.Rows[n]["Id"].ToString()!="")
					{
						model.Id=int.Parse(dt.Rows[n]["Id"].ToString());
					}
					if(dt.Rows[n]["ToUserId"].ToString()!="")
					{
						model.ToUserId=int.Parse(dt.Rows[n]["ToUserId"].ToString());
					}
					model.ActType=dt.Rows[n]["ActType"].ToString();
					if(dt.Rows[n]["SmsCount"].ToString()!="")
					{
						model.SmsCount=int.Parse(dt.Rows[n]["SmsCount"].ToString());
					}
					model.SmsType=dt.Rows[n]["SmsType"].ToString();
					if(dt.Rows[n]["FromUserId"].ToString()!="")
					{
						model.FromUserId=int.Parse(dt.Rows[n]["FromUserId"].ToString());
					}
					if(dt.Rows[n]["OperTime"].ToString()!="")
					{
						model.OperTime=DateTime.Parse(dt.Rows[n]["OperTime"].ToString());
					}
					if(dt.Rows[n]["IsPay"].ToString()!="")
					{
						model.IsPay=int.Parse(dt.Rows[n]["IsPay"].ToString());
					}
					model.Remark=dt.Rows[n]["Remark"].ToString();
					if(dt.Rows[n]["LeaveNum"].ToString()!="")
					{
						model.LeaveNum=int.Parse(dt.Rows[n]["LeaveNum"].ToString());
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

