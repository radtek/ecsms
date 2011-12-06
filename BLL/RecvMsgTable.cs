using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using ECSMS.Model;
namespace ECSMS.BLL
{
	/// <summary>
	/// RecvMsgTable
	/// </summary>
	public partial class RecvMsgTable
	{
		private readonly ECSMS.DAL.RecvMsgTable dal=new ECSMS.DAL.RecvMsgTable();
		public RecvMsgTable()
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
		public bool Exists(int MsgIndex)
		{
			return dal.Exists(MsgIndex);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(ECSMS.Model.RecvMsgTable model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(ECSMS.Model.RecvMsgTable model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int MsgIndex)
		{
			
			return dal.Delete(MsgIndex);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string MsgIndexlist )
		{
			return dal.DeleteList(MsgIndexlist );
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public ECSMS.Model.RecvMsgTable GetModel(int MsgIndex)
		{
			
			return dal.GetModel(MsgIndex);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ�����
		/// </summary>
		public ECSMS.Model.RecvMsgTable GetModelByCache(int MsgIndex)
		{
			
			string CacheKey = "RecvMsgTableModel-" + MsgIndex;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(MsgIndex);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (ECSMS.Model.RecvMsgTable)objModel;
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
		public List<ECSMS.Model.RecvMsgTable> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<ECSMS.Model.RecvMsgTable> DataTableToList(DataTable dt)
		{
			List<ECSMS.Model.RecvMsgTable> modelList = new List<ECSMS.Model.RecvMsgTable>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ECSMS.Model.RecvMsgTable model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new ECSMS.Model.RecvMsgTable();
					if(dt.Rows[n]["MsgIndex"].ToString()!="")
					{
						model.MsgIndex=int.Parse(dt.Rows[n]["MsgIndex"].ToString());
					}
					model.PhoneNumber=dt.Rows[n]["PhoneNumber"].ToString();
					model.MsgTilte=dt.Rows[n]["MsgTilte"].ToString();
					model.RecvMMSFileDir=dt.Rows[n]["RecvMMSFileDir"].ToString();
					if(dt.Rows[n]["MsgStatus"].ToString()!="")
					{
						model.MsgStatus=int.Parse(dt.Rows[n]["MsgStatus"].ToString());
					}
					if(dt.Rows[n]["MsgType"].ToString()!="")
					{
						model.MsgType=int.Parse(dt.Rows[n]["MsgType"].ToString());
					}
					if(dt.Rows[n]["RecvTime"].ToString()!="")
					{
						model.RecvTime=DateTime.Parse(dt.Rows[n]["RecvTime"].ToString());
					}
					model.ResFile1=dt.Rows[n]["ResFile1"].ToString();
					model.ResFile2=dt.Rows[n]["ResFile2"].ToString();
					model.ResFile3=dt.Rows[n]["ResFile3"].ToString();
					model.ResFile4=dt.Rows[n]["ResFile4"].ToString();
					model.ResFile5=dt.Rows[n]["ResFile5"].ToString();
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

