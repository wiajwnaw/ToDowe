using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.IO;
using System;

//不需要继承Mono类
public static class SQLLink 
{
    static string path = Application.streamingAssetsPath + "/userInformation.db";//读取表名
    static SqliteConnection sqliteConnection;
    
    public static void CreatTable()
    {
        Open();
        var command = sqliteConnection.CreateCommand();
        command.CommandText = $"CREATE TABLE userInformation(userName varchar(255),password varchar(255));";
        object res=command.ExecuteScalar();
    }
    public static bool Insert(string userName, string Password)
    {
        //插入数据命令，这里也可以链接字符串来插入自己需要的变量数据
        //如果执行删除，修改，修改语句即可，不需要改代码
        Open();
        var command = sqliteConnection.CreateCommand();
        command.CommandText = $"INSERT INTO userInformation VALUES('{userName}','{Password}'); ";
        //command.ExecuteNonQuery();//执行
        int res = command.ExecuteNonQuery();
        return res > 0;
    }
    public static bool Select(string userName,string Password)
    {
        Open();
        var command = sqliteConnection.CreateCommand();
        command.CommandText = $"SELECT * FROM userInformation WHERE userName='{userName}' and password='{Password}';";
        //command.ExecuteReader();
        SqliteDataReader reader = command.ExecuteReader();
        if (reader.HasRows)
        {
            return true;
        }
        //while(reader.Read())//一行行读取
        //{
        //    string name = (string)reader["UserName"];
        //    string password = (string)reader["Password"];
        //    Tuple<string, string> tuple = new Tuple<string,string>(name,password);
        //    return tuple;
        //}
        return false;
    }
    static void Open()
    {
        Debug.Log(path);
        if (sqliteConnection == null)
        {
            sqliteConnection = new SqliteConnection("Data Source=" + path);
            sqliteConnection.Open();
            // 判断表是否存在
            var command = sqliteConnection.CreateCommand();
            command.CommandText = $"SELECT name FROM sqlite_master WHERE type='table' AND name='userInformation';";
            var result = command.ExecuteScalar();
            if (result == null)//为空，创建
            {
                CreatTable();
            }
        }
    }

}
