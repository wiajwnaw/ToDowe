using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.IO;
using System;

//����Ҫ�̳�Mono��
public static class SQLLink 
{
    static string path = Application.streamingAssetsPath + "/userInformation.db";//��ȡ����
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
        //���������������Ҳ���������ַ����������Լ���Ҫ�ı�������
        //���ִ��ɾ�����޸ģ��޸���伴�ɣ�����Ҫ�Ĵ���
        Open();
        var command = sqliteConnection.CreateCommand();
        command.CommandText = $"INSERT INTO userInformation VALUES('{userName}','{Password}'); ";
        //command.ExecuteNonQuery();//ִ��
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
        //while(reader.Read())//һ���ж�ȡ
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
            // �жϱ��Ƿ����
            var command = sqliteConnection.CreateCommand();
            command.CommandText = $"SELECT name FROM sqlite_master WHERE type='table' AND name='userInformation';";
            var result = command.ExecuteScalar();
            if (result == null)//Ϊ�գ�����
            {
                CreatTable();
            }
        }
    }

}
