using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using ECSMS.Model;
namespace ECSMS.BLL
{
	/// <summary>
	/// SendMsgTable
	/// </summary>
	public partial class SendMsgTable
	{
		private readonly ECSMS.DAL.SendMsgTable dal=new ECSMS.DAL.SendMsgTable();
		public SendMsgTable()
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
		public int  Add(ECSMS.Model.SendMsgTable model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(ECSMS.Model.SendMsgTable model)
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
		public ECSMS.Model.SendMsgTable GetModel(int MsgIndex)
		{
			
			return dal.GetModel(MsgIndex);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ�����
		/// </summary>
		public ECSMS.Model.SendMsgTable GetModelByCache(int MsgIndex)
		{
			
			string CacheKey = "SendMsgTableModel-" + MsgIndex;
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
			return (ECSMS.Model.SendMsgTable)objModel;
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
		public List<ECSMS.Model.SendMsgTable> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<ECSMS.Model.SendMsgTable> DataTableToList(DataTable dt)
		{
			List<ECSMS.Model.SendMsgTable> modelList = new List<ECSMS.Model.SendMsgTable>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ECSMS.Model.SendMsgTable model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new ECSMS.Model.SendMsgTable();
					if(dt.Rows[n]["MsgIndex"].ToString()!="")
					{
						model.MsgIndex=int.Parse(dt.Rows[n]["MsgIndex"].ToString());
					}
					model.PhoneNumber=dt.Rows[n]["PhoneNumber"].ToString();
					model.MsgTitle=dt.Rows[n]["MsgTitle"].ToString();
					model.MMSInfoFile=dt.Rows[n]["MMSInfoFile"].ToString();
					model.TimeSend=dt.Rows[n]["TimeSend"].ToString();
					if(dt.Rows[n]["MsgStatus"].ToString()!="")
					{
						model.MsgStatus=int.Parse(dt.Rows[n]["MsgStatus"].ToString());
					}
					model.MsgType=dt.Rows[n]["MsgType"].ToString();
					model.SentTime=dt.Rows[n]["SentTime"].ToString();
					model.RunInfo=dt.Rows[n]["RunInfo"].ToString();
					model.SendReport=dt.Rows[n]["SendReport"].ToString();
					model.ServerMsgID=dt.Rows[n]["ServerMsgID"].ToString();
					if(dt.Rows[n]["SpId"].ToString()!="")
					{
						model.SpId=int.Parse(dt.Rows[n]["SpId"].ToString());
					}
					if(dt.Rows[n]["UserId"].ToString()!="")
					{
						model.UserId=int.Parse(dt.Rows[n]["UserId"].ToString());
					}
					if(dt.Rows[n]["IsExperNum"].ToString()!="")
					{
						model.IsExperNum=int.Parse(dt.Rows[n]["IsExperNum"].ToString());
					}
					if(dt.Rows[n]["SendNum"].ToString()!="")
					{
						model.SendNum=int.Parse(dt.Rows[n]["SendNum"].ToString());
					}
					if(dt.Rows[n]["SendTime"].ToString()!="")
					{
						model.SendTime=DateTime.Parse(dt.Rows[n]["SendTime"].ToString());
					}
					if(dt.Rows[n]["ExerNumbers"].ToString()!="")
					{
						model.ExerNumbers=int.Parse(dt.Rows[n]["ExerNumbers"].ToString());
					}
					if(dt.Rows[n]["NumbersCount"].ToString()!="")
					{
						model.NumbersCount=int.Parse(dt.Rows[n]["NumbersCount"].ToString());
					}
					model.ServerID=dt.Rows[n]["ServerID"].ToString();
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

