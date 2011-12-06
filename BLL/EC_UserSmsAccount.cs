using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using ECSMS.Model;
namespace ECSMS.BLL
{
	/// <summary>
	/// EC_UserSmsAccount
	/// </summary>
	public partial class EC_UserSmsAccount
	{
		private readonly ECSMS.DAL.EC_UserSmsAccount dal=new ECSMS.DAL.EC_UserSmsAccount();
		public EC_UserSmsAccount()
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
		public int  Add(ECSMS.Model.EC_UserSmsAccount model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(ECSMS.Model.EC_UserSmsAccount model)
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
		public ECSMS.Model.EC_UserSmsAccount GetModel(int Id)
		{
			
			return dal.GetModel(Id);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ�����
		/// </summary>
		public ECSMS.Model.EC_UserSmsAccount GetModelByCache(int Id)
		{
			
			string CacheKey = "EC_UserSmsAccountModel-" + Id;
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
			return (ECSMS.Model.EC_UserSmsAccount)objModel;
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
		public List<ECSMS.Model.EC_UserSmsAccount> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<ECSMS.Model.EC_UserSmsAccount> DataTableToList(DataTable dt)
		{
			List<ECSMS.Model.EC_UserSmsAccount> modelList = new List<ECSMS.Model.EC_UserSmsAccount>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ECSMS.Model.EC_UserSmsAccount model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new ECSMS.Model.EC_UserSmsAccount();
					if(dt.Rows[n]["Id"].ToString()!="")
					{
						model.Id=int.Parse(dt.Rows[n]["Id"].ToString());
					}
					if(dt.Rows[n]["UserId"].ToString()!="")
					{
						model.UserId=int.Parse(dt.Rows[n]["UserId"].ToString());
					}
					model.SmsType=dt.Rows[n]["SmsType"].ToString();
					if(dt.Rows[n]["InitNum"].ToString()!="")
					{
						model.InitNum=int.Parse(dt.Rows[n]["InitNum"].ToString());
					}
					if(dt.Rows[n]["LargessNum"].ToString()!="")
					{
						model.LargessNum=int.Parse(dt.Rows[n]["LargessNum"].ToString());
					}
					if(dt.Rows[n]["LeaveNum"].ToString()!="")
					{
						model.LeaveNum=int.Parse(dt.Rows[n]["LeaveNum"].ToString());
					}
					if(dt.Rows[n]["AwokeNum"].ToString()!="")
					{
						model.AwokeNum=int.Parse(dt.Rows[n]["AwokeNum"].ToString());
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

