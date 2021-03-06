/**************************************************
* 创建作者：	咕咕咕
* 创建时间：	2020-12-31
* 作用描述：	#资源接口
***************************************************/

using System;

namespace Utils
{
	public interface IRes : IRecyclable, IRequestTask
	{
		string Url { get; }

		string LoaderName { get; }

		byte[] Datas { get; }

		int RefCount { get; }

		void AddRef();

		void ReduceRef();

		void Request();

		float Progress { get; }

		void Release();

		void RegisterEvent(Action<bool, IRes> onFinish);
	}

	public enum ResState
    {
		Waiting,
		Loading,
		Cancel,
		Completed,
		Error
    }

	public enum ResType
    {
		Json,
		DownloadRes
    }
}