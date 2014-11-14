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

namespace LibraryDatabase
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LibraryDatabase")]
	public partial class LibraryDbContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAuthor(Author instance);
    partial void UpdateAuthor(Author instance);
    partial void DeleteAuthor(Author instance);
    partial void InsertBook(Book instance);
    partial void UpdateBook(Book instance);
    partial void DeleteBook(Book instance);
    partial void InsertGenre(Genre instance);
    partial void UpdateGenre(Genre instance);
    partial void DeleteGenre(Genre instance);
    #endregion
		
		public LibraryDbContext() : 
				base(global::LibraryDatabase.Properties.Settings.Default.LibraryDatabaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LibraryDbContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LibraryDbContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LibraryDbContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LibraryDbContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Author> Authors
		{
			get
			{
				return this.GetTable<Author>();
			}
		}
		
		public System.Data.Linq.Table<Book> Books
		{
			get
			{
				return this.GetTable<Book>();
			}
		}
		
		public System.Data.Linq.Table<Genre> Genres
		{
			get
			{
				return this.GetTable<Genre>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Authors")]
	public partial class Author : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AuthorID;
		
		private string _AuthorFirstName;
		
		private string _AuthorLastName;
		
		private System.Nullable<System.DateTime> _AuthorBirthDate;
		
		private EntitySet<Book> _Books;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAuthorIDChanging(int value);
    partial void OnAuthorIDChanged();
    partial void OnAuthorFirstNameChanging(string value);
    partial void OnAuthorFirstNameChanged();
    partial void OnAuthorLastNameChanging(string value);
    partial void OnAuthorLastNameChanged();
    partial void OnAuthorBirthDateChanging(System.Nullable<System.DateTime> value);
    partial void OnAuthorBirthDateChanged();
    #endregion
		
		public Author()
		{
			this._Books = new EntitySet<Book>(new Action<Book>(this.attach_Books), new Action<Book>(this.detach_Books));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AuthorID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int AuthorID
		{
			get
			{
				return this._AuthorID;
			}
			set
			{
				if ((this._AuthorID != value))
				{
					this.OnAuthorIDChanging(value);
					this.SendPropertyChanging();
					this._AuthorID = value;
					this.SendPropertyChanged("AuthorID");
					this.OnAuthorIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AuthorFirstName", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string AuthorFirstName
		{
			get
			{
				return this._AuthorFirstName;
			}
			set
			{
				if ((this._AuthorFirstName != value))
				{
					this.OnAuthorFirstNameChanging(value);
					this.SendPropertyChanging();
					this._AuthorFirstName = value;
					this.SendPropertyChanged("AuthorFirstName");
					this.OnAuthorFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AuthorLastName", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string AuthorLastName
		{
			get
			{
				return this._AuthorLastName;
			}
			set
			{
				if ((this._AuthorLastName != value))
				{
					this.OnAuthorLastNameChanging(value);
					this.SendPropertyChanging();
					this._AuthorLastName = value;
					this.SendPropertyChanged("AuthorLastName");
					this.OnAuthorLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AuthorBirthDate", DbType="Date")]
		public System.Nullable<System.DateTime> AuthorBirthDate
		{
			get
			{
				return this._AuthorBirthDate;
			}
			set
			{
				if ((this._AuthorBirthDate != value))
				{
					this.OnAuthorBirthDateChanging(value);
					this.SendPropertyChanging();
					this._AuthorBirthDate = value;
					this.SendPropertyChanged("AuthorBirthDate");
					this.OnAuthorBirthDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Author_Book", Storage="_Books", ThisKey="AuthorID", OtherKey="AuthorID")]
		public EntitySet<Book> Books
		{
			get
			{
				return this._Books;
			}
			set
			{
				this._Books.Assign(value);
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
		
		private void attach_Books(Book entity)
		{
			this.SendPropertyChanging();
			entity.Author = this;
		}
		
		private void detach_Books(Book entity)
		{
			this.SendPropertyChanging();
			entity.Author = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Books")]
	public partial class Book : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _BookID;
		
		private int _AuthorID;
		
		private int _GenreID;
		
		private string _BookName;
		
		private System.Nullable<int> _BookQuantity;
		
		private EntityRef<Author> _Author;
		
		private EntityRef<Genre> _Genre;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBookIDChanging(int value);
    partial void OnBookIDChanged();
    partial void OnAuthorIDChanging(int value);
    partial void OnAuthorIDChanged();
    partial void OnGenreIDChanging(int value);
    partial void OnGenreIDChanged();
    partial void OnBookNameChanging(string value);
    partial void OnBookNameChanged();
    partial void OnBookQuantityChanging(System.Nullable<int> value);
    partial void OnBookQuantityChanged();
    #endregion
		
		public Book()
		{
			this._Author = default(EntityRef<Author>);
			this._Genre = default(EntityRef<Genre>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int BookID
		{
			get
			{
				return this._BookID;
			}
			set
			{
				if ((this._BookID != value))
				{
					this.OnBookIDChanging(value);
					this.SendPropertyChanging();
					this._BookID = value;
					this.SendPropertyChanged("BookID");
					this.OnBookIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AuthorID", DbType="Int NOT NULL")]
		public int AuthorID
		{
			get
			{
				return this._AuthorID;
			}
			set
			{
				if ((this._AuthorID != value))
				{
					if (this._Author.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAuthorIDChanging(value);
					this.SendPropertyChanging();
					this._AuthorID = value;
					this.SendPropertyChanged("AuthorID");
					this.OnAuthorIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GenreID", DbType="Int NOT NULL")]
		public int GenreID
		{
			get
			{
				return this._GenreID;
			}
			set
			{
				if ((this._GenreID != value))
				{
					if (this._Genre.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnGenreIDChanging(value);
					this.SendPropertyChanging();
					this._GenreID = value;
					this.SendPropertyChanged("GenreID");
					this.OnGenreIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookName", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string BookName
		{
			get
			{
				return this._BookName;
			}
			set
			{
				if ((this._BookName != value))
				{
					this.OnBookNameChanging(value);
					this.SendPropertyChanging();
					this._BookName = value;
					this.SendPropertyChanged("BookName");
					this.OnBookNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookQuantity", DbType="Int")]
		public System.Nullable<int> BookQuantity
		{
			get
			{
				return this._BookQuantity;
			}
			set
			{
				if ((this._BookQuantity != value))
				{
					this.OnBookQuantityChanging(value);
					this.SendPropertyChanging();
					this._BookQuantity = value;
					this.SendPropertyChanged("BookQuantity");
					this.OnBookQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Author_Book", Storage="_Author", ThisKey="AuthorID", OtherKey="AuthorID", IsForeignKey=true)]
		public Author Author
		{
			get
			{
				return this._Author.Entity;
			}
			set
			{
				Author previousValue = this._Author.Entity;
				if (((previousValue != value) 
							|| (this._Author.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Author.Entity = null;
						previousValue.Books.Remove(this);
					}
					this._Author.Entity = value;
					if ((value != null))
					{
						value.Books.Add(this);
						this._AuthorID = value.AuthorID;
					}
					else
					{
						this._AuthorID = default(int);
					}
					this.SendPropertyChanged("Author");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Genre_Book", Storage="_Genre", ThisKey="GenreID", OtherKey="GenreID", IsForeignKey=true)]
		public Genre Genre
		{
			get
			{
				return this._Genre.Entity;
			}
			set
			{
				Genre previousValue = this._Genre.Entity;
				if (((previousValue != value) 
							|| (this._Genre.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Genre.Entity = null;
						previousValue.Books.Remove(this);
					}
					this._Genre.Entity = value;
					if ((value != null))
					{
						value.Books.Add(this);
						this._GenreID = value.GenreID;
					}
					else
					{
						this._GenreID = default(int);
					}
					this.SendPropertyChanged("Genre");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Genres")]
	public partial class Genre : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _GenreID;
		
		private string _GenreName;
		
		private EntitySet<Book> _Books;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnGenreIDChanging(int value);
    partial void OnGenreIDChanged();
    partial void OnGenreNameChanging(string value);
    partial void OnGenreNameChanged();
    #endregion
		
		public Genre()
		{
			this._Books = new EntitySet<Book>(new Action<Book>(this.attach_Books), new Action<Book>(this.detach_Books));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GenreID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int GenreID
		{
			get
			{
				return this._GenreID;
			}
			set
			{
				if ((this._GenreID != value))
				{
					this.OnGenreIDChanging(value);
					this.SendPropertyChanging();
					this._GenreID = value;
					this.SendPropertyChanged("GenreID");
					this.OnGenreIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GenreName", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string GenreName
		{
			get
			{
				return this._GenreName;
			}
			set
			{
				if ((this._GenreName != value))
				{
					this.OnGenreNameChanging(value);
					this.SendPropertyChanging();
					this._GenreName = value;
					this.SendPropertyChanged("GenreName");
					this.OnGenreNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Genre_Book", Storage="_Books", ThisKey="GenreID", OtherKey="GenreID")]
		public EntitySet<Book> Books
		{
			get
			{
				return this._Books;
			}
			set
			{
				this._Books.Assign(value);
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
		
		private void attach_Books(Book entity)
		{
			this.SendPropertyChanging();
			entity.Genre = this;
		}
		
		private void detach_Books(Book entity)
		{
			this.SendPropertyChanging();
			entity.Genre = null;
		}
	}
}
#pragma warning restore 1591