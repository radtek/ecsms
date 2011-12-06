using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using ECSMS.Model;
namespace ECSMS.BLL
{
	/// <summary>
	/// EC_Customer
	/// </summary>
	public partial class EC_Customer
	{
		private readonly ECSMS.DAL.EC_Customer dal=new ECSMS.DAL.EC_Customer();
		public EC_Customer()
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
		public int  Add(ECSMS.Model.EC_Customer model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(ECSMS.Model.EC_Customer model)
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
		public ECSMS.Model.EC_Customer GetModel(int Id)
		{
			
			return dal.GetModel(Id);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ�����
		/// </summary>
		public ECSMS.Model.EC_Customer GetModelByCache(int Id)
		{
			
			string CacheKey = "EC_CustomerModel-" + Id;
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
			return (ECSMS.Model.EC_Customer)objModel;
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
		public List<ECSMS.Model.EC_Customer> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<ECSMS.Model.EC_Customer> DataTableToList(DataTable dt)
		{
			List<ECSMS.Model.EC_Customer> modelList = new List<ECSMS.Model.EC_Customer>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ECSMS.Model.EC_Customer model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new ECSMS.Model.EC_Customer();
					if(dt.Rows[n]["Id"].ToString()!="")
					{
						model.Id=int.Parse(dt.Rows[n]["Id"].ToString());
					}
					model.Name=dt.Rows[n]["Name"].ToString();
					model.NickName=dt.Rows[n]["NickName"].ToString();
					model.Mobile=dt.Rows[n]["Mobile"].ToString();
					model.Sex=dt.Rows[n]["Sex"].ToString();
					model.CompanyName=dt.Rows[n]["CompanyName"].ToString();
					model.Partment=dt.Rows[n]["Partment"].ToString();
					model.Positions=dt.Rows[n]["Positions"].ToString();
					model.CompanyAddress=dt.Rows[n]["CompanyAddress"].ToString();
					model.Website=dt.Rows[n]["Website"].ToString();
					model.Telephone=dt.Rows[n]["Telephone"].ToString();
					model.Fax=dt.Rows[n]["Fax"].ToString();
					model.QQ=dt.Rows[n]["QQ"].ToString();
					model.mobile2=dt.Rows[n]["mobile2"].ToString();
					model.HomeTel=dt.Rows[n]["HomeTel"].ToString();
					model.HomeAddress=dt.Rows[n]["HomeAddress"].ToString();
					model.Email=dt.Rows[n]["Email"].ToString();
					model.Birthday=dt.Rows[n]["Birthday"].ToString();
					model.CardNumber=dt.Rows[n]["CardNumber"].ToString();
					model.Servicer=dt.Rows[n]["Servicer"].ToString();
					if(dt.Rows[n]["StartDate"].ToString()!="")
					{
						model.StartDate=DateTime.Parse(dt.Rows[n]["StartDate"].ToString());
					}
					if(dt.Rows[n]["EndDate"].ToString()!="")
					{
						model.EndDate=DateTime.Parse(dt.Rows[n]["EndDate"].ToString());
					}
					model.Favrate=dt.Rows[n]["Favrate"].ToString();
					model.RelationLevel=dt.Rows[n]["RelationLevel"].ToString();
					model.PostCode=dt.Rows[n]["PostCode"].ToString();
					model.Remark=dt.Rows[n]["Remark"].ToString();
					if(dt.Rows[n]["GroupId"].ToString()!="")
					{
						model.GroupId=int.Parse(dt.Rows[n]["GroupId"].ToString());
					}
					if(dt.Rows[n]["UserId"].ToString()!="")
					{
						model.UserId=int.Parse(dt.Rows[n]["UserId"].ToString());
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

