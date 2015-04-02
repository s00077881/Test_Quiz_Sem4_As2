﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment1_Quiz
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Quiz_ProjectData")]
	public partial class ProjectDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertQuize(Quize instance);
    partial void UpdateQuize(Quize instance);
    partial void DeleteQuize(Quize instance);
    partial void InsertQuizQuestion(QuizQuestion instance);
    partial void UpdateQuizQuestion(QuizQuestion instance);
    partial void DeleteQuizQuestion(QuizQuestion instance);
    partial void InsertQuizAnswer(QuizAnswer instance);
    partial void UpdateQuizAnswer(QuizAnswer instance);
    partial void DeleteQuizAnswer(QuizAnswer instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertNationality(Nationality instance);
    partial void UpdateNationality(Nationality instance);
    partial void DeleteNationality(Nationality instance);
    partial void InsertAttempt(Attempt instance);
    partial void UpdateAttempt(Attempt instance);
    partial void DeleteAttempt(Attempt instance);
    #endregion
		
		public ProjectDataDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ProjectDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProjectDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProjectDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProjectDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Quize> Quizes
		{
			get
			{
				return this.GetTable<Quize>();
			}
		}
		
		public System.Data.Linq.Table<QuizQuestion> QuizQuestions
		{
			get
			{
				return this.GetTable<QuizQuestion>();
			}
		}
		
		public System.Data.Linq.Table<QuizAnswer> QuizAnswers
		{
			get
			{
				return this.GetTable<QuizAnswer>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Nationality> Nationalities
		{
			get
			{
				return this.GetTable<Nationality>();
			}
		}
		
		public System.Data.Linq.Table<Attempt> Attempts
		{
			get
			{
				return this.GetTable<Attempt>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Quizes")]
	public partial class Quize : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Category;
		
		private System.Nullable<int> _TotalTimesTaken;
		
		private System.Nullable<int> _TotalScore;
		
		private EntitySet<QuizQuestion> _QuizQuestions;
		
		private EntitySet<Attempt> _Attempts;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnCategoryChanging(string value);
    partial void OnCategoryChanged();
    partial void OnTotalTimesTakenChanging(System.Nullable<int> value);
    partial void OnTotalTimesTakenChanged();
    partial void OnTotalScoreChanging(System.Nullable<int> value);
    partial void OnTotalScoreChanged();
    #endregion
		
		public Quize()
		{
			this._QuizQuestions = new EntitySet<QuizQuestion>(new Action<QuizQuestion>(this.attach_QuizQuestions), new Action<QuizQuestion>(this.detach_QuizQuestions));
			this._Attempts = new EntitySet<Attempt>(new Action<Attempt>(this.attach_Attempts), new Action<Attempt>(this.detach_Attempts));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NChar(30)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Category", DbType="NChar(30)")]
		public string Category
		{
			get
			{
				return this._Category;
			}
			set
			{
				if ((this._Category != value))
				{
					this.OnCategoryChanging(value);
					this.SendPropertyChanging();
					this._Category = value;
					this.SendPropertyChanged("Category");
					this.OnCategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalTimesTaken", DbType="Int")]
		public System.Nullable<int> TotalTimesTaken
		{
			get
			{
				return this._TotalTimesTaken;
			}
			set
			{
				if ((this._TotalTimesTaken != value))
				{
					this.OnTotalTimesTakenChanging(value);
					this.SendPropertyChanging();
					this._TotalTimesTaken = value;
					this.SendPropertyChanged("TotalTimesTaken");
					this.OnTotalTimesTakenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalScore", DbType="Int")]
		public System.Nullable<int> TotalScore
		{
			get
			{
				return this._TotalScore;
			}
			set
			{
				if ((this._TotalScore != value))
				{
					this.OnTotalScoreChanging(value);
					this.SendPropertyChanging();
					this._TotalScore = value;
					this.SendPropertyChanged("TotalScore");
					this.OnTotalScoreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Quize_QuizQuestion", Storage="_QuizQuestions", ThisKey="Id", OtherKey="QuizId")]
		public EntitySet<QuizQuestion> QuizQuestions
		{
			get
			{
				return this._QuizQuestions;
			}
			set
			{
				this._QuizQuestions.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Quize_Attempt", Storage="_Attempts", ThisKey="Id", OtherKey="QuizID")]
		public EntitySet<Attempt> Attempts
		{
			get
			{
				return this._Attempts;
			}
			set
			{
				this._Attempts.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_QuizQuestions(QuizQuestion entity)
		{
			this.SendPropertyChanging();
			entity.Quize = this;
		}
		
		private void detach_QuizQuestions(QuizQuestion entity)
		{
			this.SendPropertyChanging();
			entity.Quize = null;
		}
		
		private void attach_Attempts(Attempt entity)
		{
			this.SendPropertyChanging();
			entity.Quize = this;
		}
		
		private void detach_Attempts(Attempt entity)
		{
			this.SendPropertyChanging();
			entity.Quize = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.QuizQuestions")]
	public partial class QuizQuestion : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _QuizId;
		
		private string _Question;
		
		private int _QuestionId;
		
		private EntitySet<QuizAnswer> _QuizAnswers;
		
		private EntityRef<Quize> _Quize;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnQuizIdChanging(int value);
    partial void OnQuizIdChanged();
    partial void OnQuestionChanging(string value);
    partial void OnQuestionChanged();
    partial void OnQuestionIdChanging(int value);
    partial void OnQuestionIdChanged();
    #endregion
		
		public QuizQuestion()
		{
			this._QuizAnswers = new EntitySet<QuizAnswer>(new Action<QuizAnswer>(this.attach_QuizAnswers), new Action<QuizAnswer>(this.detach_QuizAnswers));
			this._Quize = default(EntityRef<Quize>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuizId", DbType="Int NOT NULL")]
		public int QuizId
		{
			get
			{
				return this._QuizId;
			}
			set
			{
				if ((this._QuizId != value))
				{
					if (this._Quize.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnQuizIdChanging(value);
					this.SendPropertyChanging();
					this._QuizId = value;
					this.SendPropertyChanged("QuizId");
					this.OnQuizIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Question", DbType="VarChar(MAX)")]
		public string Question
		{
			get
			{
				return this._Question;
			}
			set
			{
				if ((this._Question != value))
				{
					this.OnQuestionChanging(value);
					this.SendPropertyChanging();
					this._Question = value;
					this.SendPropertyChanged("Question");
					this.OnQuestionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuestionId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int QuestionId
		{
			get
			{
				return this._QuestionId;
			}
			set
			{
				if ((this._QuestionId != value))
				{
					this.OnQuestionIdChanging(value);
					this.SendPropertyChanging();
					this._QuestionId = value;
					this.SendPropertyChanged("QuestionId");
					this.OnQuestionIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="QuizQuestion_QuizAnswer", Storage="_QuizAnswers", ThisKey="QuestionId", OtherKey="QuestionId")]
		public EntitySet<QuizAnswer> QuizAnswers
		{
			get
			{
				return this._QuizAnswers;
			}
			set
			{
				this._QuizAnswers.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Quize_QuizQuestion", Storage="_Quize", ThisKey="QuizId", OtherKey="Id", IsForeignKey=true)]
		public Quize Quize
		{
			get
			{
				return this._Quize.Entity;
			}
			set
			{
				Quize previousValue = this._Quize.Entity;
				if (((previousValue != value) 
							|| (this._Quize.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Quize.Entity = null;
						previousValue.QuizQuestions.Remove(this);
					}
					this._Quize.Entity = value;
					if ((value != null))
					{
						value.QuizQuestions.Add(this);
						this._QuizId = value.Id;
					}
					else
					{
						this._QuizId = default(int);
					}
					this.SendPropertyChanged("Quize");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_QuizAnswers(QuizAnswer entity)
		{
			this.SendPropertyChanging();
			entity.QuizQuestion = this;
		}
		
		private void detach_QuizAnswers(QuizAnswer entity)
		{
			this.SendPropertyChanging();
			entity.QuizQuestion = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.QuizAnswers")]
	public partial class QuizAnswer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _QuestionId;
		
		private string _Answer;
		
		private System.Nullable<int> _Value;
		
		private int _AnswerId;
		
		private EntityRef<QuizQuestion> _QuizQuestion;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnQuestionIdChanging(int value);
    partial void OnQuestionIdChanged();
    partial void OnAnswerChanging(string value);
    partial void OnAnswerChanged();
    partial void OnValueChanging(System.Nullable<int> value);
    partial void OnValueChanged();
    partial void OnAnswerIdChanging(int value);
    partial void OnAnswerIdChanged();
    #endregion
		
		public QuizAnswer()
		{
			this._QuizQuestion = default(EntityRef<QuizQuestion>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuestionId", DbType="Int NOT NULL")]
		public int QuestionId
		{
			get
			{
				return this._QuestionId;
			}
			set
			{
				if ((this._QuestionId != value))
				{
					if (this._QuizQuestion.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnQuestionIdChanging(value);
					this.SendPropertyChanging();
					this._QuestionId = value;
					this.SendPropertyChanged("QuestionId");
					this.OnQuestionIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Answer", DbType="VarChar(MAX)")]
		public string Answer
		{
			get
			{
				return this._Answer;
			}
			set
			{
				if ((this._Answer != value))
				{
					this.OnAnswerChanging(value);
					this.SendPropertyChanging();
					this._Answer = value;
					this.SendPropertyChanged("Answer");
					this.OnAnswerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Value", DbType="Int")]
		public System.Nullable<int> Value
		{
			get
			{
				return this._Value;
			}
			set
			{
				if ((this._Value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._Value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnswerId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int AnswerId
		{
			get
			{
				return this._AnswerId;
			}
			set
			{
				if ((this._AnswerId != value))
				{
					this.OnAnswerIdChanging(value);
					this.SendPropertyChanging();
					this._AnswerId = value;
					this.SendPropertyChanged("AnswerId");
					this.OnAnswerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="QuizQuestion_QuizAnswer", Storage="_QuizQuestion", ThisKey="QuestionId", OtherKey="QuestionId", IsForeignKey=true)]
		public QuizQuestion QuizQuestion
		{
			get
			{
				return this._QuizQuestion.Entity;
			}
			set
			{
				QuizQuestion previousValue = this._QuizQuestion.Entity;
				if (((previousValue != value) 
							|| (this._QuizQuestion.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._QuizQuestion.Entity = null;
						previousValue.QuizAnswers.Remove(this);
					}
					this._QuizQuestion.Entity = value;
					if ((value != null))
					{
						value.QuizAnswers.Add(this);
						this._QuestionId = value.QuestionId;
					}
					else
					{
						this._QuestionId = default(int);
					}
					this.SendPropertyChanged("QuizQuestion");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserID;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _Email;
		
		private System.Nullable<int> _NationalityID;
		
		private EntitySet<Attempt> _Attempts;
		
		private EntityRef<Nationality> _Nationality;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnNationalityIDChanging(System.Nullable<int> value);
    partial void OnNationalityIDChanged();
    #endregion
		
		public User()
		{
			this._Attempts = new EntitySet<Attempt>(new Action<Attempt>(this.attach_Attempts), new Action<Attempt>(this.detach_Attempts));
			this._Nationality = default(EntityRef<Nationality>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(50)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(50)")]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NationalityID", DbType="Int")]
		public System.Nullable<int> NationalityID
		{
			get
			{
				return this._NationalityID;
			}
			set
			{
				if ((this._NationalityID != value))
				{
					if (this._Nationality.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnNationalityIDChanging(value);
					this.SendPropertyChanging();
					this._NationalityID = value;
					this.SendPropertyChanged("NationalityID");
					this.OnNationalityIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Attempt", Storage="_Attempts", ThisKey="UserID", OtherKey="UserID")]
		public EntitySet<Attempt> Attempts
		{
			get
			{
				return this._Attempts;
			}
			set
			{
				this._Attempts.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Nationality_User", Storage="_Nationality", ThisKey="NationalityID", OtherKey="Id", IsForeignKey=true)]
		public Nationality Nationality
		{
			get
			{
				return this._Nationality.Entity;
			}
			set
			{
				Nationality previousValue = this._Nationality.Entity;
				if (((previousValue != value) 
							|| (this._Nationality.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Nationality.Entity = null;
						previousValue.Users.Remove(this);
					}
					this._Nationality.Entity = value;
					if ((value != null))
					{
						value.Users.Add(this);
						this._NationalityID = value.Id;
					}
					else
					{
						this._NationalityID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Nationality");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Attempts(Attempt entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Attempts(Attempt entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Nationalities")]
	public partial class Nationality : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Nationality1;
		
		private EntitySet<User> _Users;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNationality1Changing(string value);
    partial void OnNationality1Changed();
    #endregion
		
		public Nationality()
		{
			this._Users = new EntitySet<User>(new Action<User>(this.attach_Users), new Action<User>(this.detach_Users));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Nationality", Storage="_Nationality1", DbType="VarChar(30)")]
		public string Nationality1
		{
			get
			{
				return this._Nationality1;
			}
			set
			{
				if ((this._Nationality1 != value))
				{
					this.OnNationality1Changing(value);
					this.SendPropertyChanging();
					this._Nationality1 = value;
					this.SendPropertyChanged("Nationality1");
					this.OnNationality1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Nationality_User", Storage="_Users", ThisKey="Id", OtherKey="NationalityID")]
		public EntitySet<User> Users
		{
			get
			{
				return this._Users;
			}
			set
			{
				this._Users.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Users(User entity)
		{
			this.SendPropertyChanging();
			entity.Nationality = this;
		}
		
		private void detach_Users(User entity)
		{
			this.SendPropertyChanging();
			entity.Nationality = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Attempts")]
	public partial class Attempt : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AttemptID;
		
		private System.Nullable<int> _UserID;
		
		private System.Nullable<int> _QuizID;
		
		private System.Nullable<System.DateTime> _TimeStart;
		
		private System.Nullable<System.DateTime> _TimeEnd;
		
		private System.Nullable<int> _Score;
		
		private EntityRef<User> _User;
		
		private EntityRef<Quize> _Quize;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAttemptIDChanging(int value);
    partial void OnAttemptIDChanged();
    partial void OnUserIDChanging(System.Nullable<int> value);
    partial void OnUserIDChanged();
    partial void OnQuizIDChanging(System.Nullable<int> value);
    partial void OnQuizIDChanged();
    partial void OnTimeStartChanging(System.Nullable<System.DateTime> value);
    partial void OnTimeStartChanged();
    partial void OnTimeEndChanging(System.Nullable<System.DateTime> value);
    partial void OnTimeEndChanged();
    partial void OnScoreChanging(System.Nullable<int> value);
    partial void OnScoreChanged();
    #endregion
		
		public Attempt()
		{
			this._User = default(EntityRef<User>);
			this._Quize = default(EntityRef<Quize>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AttemptID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int AttemptID
		{
			get
			{
				return this._AttemptID;
			}
			set
			{
				if ((this._AttemptID != value))
				{
					this.OnAttemptIDChanging(value);
					this.SendPropertyChanging();
					this._AttemptID = value;
					this.SendPropertyChanged("AttemptID");
					this.OnAttemptIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int")]
		public System.Nullable<int> UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuizID", DbType="Int")]
		public System.Nullable<int> QuizID
		{
			get
			{
				return this._QuizID;
			}
			set
			{
				if ((this._QuizID != value))
				{
					if (this._Quize.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnQuizIDChanging(value);
					this.SendPropertyChanging();
					this._QuizID = value;
					this.SendPropertyChanged("QuizID");
					this.OnQuizIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimeStart", DbType="DateTime")]
		public System.Nullable<System.DateTime> TimeStart
		{
			get
			{
				return this._TimeStart;
			}
			set
			{
				if ((this._TimeStart != value))
				{
					this.OnTimeStartChanging(value);
					this.SendPropertyChanging();
					this._TimeStart = value;
					this.SendPropertyChanged("TimeStart");
					this.OnTimeStartChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimeEnd", DbType="DateTime")]
		public System.Nullable<System.DateTime> TimeEnd
		{
			get
			{
				return this._TimeEnd;
			}
			set
			{
				if ((this._TimeEnd != value))
				{
					this.OnTimeEndChanging(value);
					this.SendPropertyChanging();
					this._TimeEnd = value;
					this.SendPropertyChanged("TimeEnd");
					this.OnTimeEndChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Score", DbType="Int")]
		public System.Nullable<int> Score
		{
			get
			{
				return this._Score;
			}
			set
			{
				if ((this._Score != value))
				{
					this.OnScoreChanging(value);
					this.SendPropertyChanging();
					this._Score = value;
					this.SendPropertyChanged("Score");
					this.OnScoreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Attempt", Storage="_User", ThisKey="UserID", OtherKey="UserID", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Attempts.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Attempts.Add(this);
						this._UserID = value.UserID;
					}
					else
					{
						this._UserID = default(Nullable<int>);
					}
					this.SendPropertyChanged("User");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Quize_Attempt", Storage="_Quize", ThisKey="QuizID", OtherKey="Id", IsForeignKey=true)]
		public Quize Quize
		{
			get
			{
				return this._Quize.Entity;
			}
			set
			{
				Quize previousValue = this._Quize.Entity;
				if (((previousValue != value) 
							|| (this._Quize.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Quize.Entity = null;
						previousValue.Attempts.Remove(this);
					}
					this._Quize.Entity = value;
					if ((value != null))
					{
						value.Attempts.Add(this);
						this._QuizID = value.Id;
					}
					else
					{
						this._QuizID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Quize");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
