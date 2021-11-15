<<<<<<< HEAD
﻿// ***********************************************************************
// Assembly         : PSC.Blazor.Components.DataTable
// Author           : Enrico Rossini
// Created          : 11-14-2021
//
// Last Modified By : Enrico Rossini
// Last Modified On : 11-14-2021
// ***********************************************************************
// <copyright file="RequestArgs.cs" company="Enrico Rossini - PureSourceCode.com">
//     Enrico Rossini - PureSourceCode.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using PSC.Blazor.Components.DataTable.Code;
=======
﻿using PSC.Blazor.Components.DataTable.Code;
>>>>>>> 8067c1cc92c53e34d87ef71bf5c8fe928812459e
using PSC.Blazor.Components.DataTable.Code.Filters;
using PSC.Blazor.Components.DataTable.Enums;
using PSC.Blazor.Components.DataTable.Models;
using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Linq.Expressions;

namespace PSC.Blazor.Components.DataTable.EventsArgs
{
	/// <summary>
	/// Class RequestArgs.
	/// </summary>
	/// <typeparam name="TModel">The type of the t model.</typeparam>
	public class RequestArgs<TModel>
	{
		/// <summary>
		/// Gets or sets the page nr.
		/// </summary>
		/// <value>The page nr.</value>
		public int PageNr { get; set; }

		/// <summary>
		/// Gets or sets the size of the page.
		/// </summary>
		/// <value>The size of the page.</value>
		public int PageSize { get; set; }

		/// <summary>
		/// Gets or sets the sort direction.
		/// </summary>
		/// <value>The sort direction.</value>
		public SortDirection SortDirection { get; set; }

		/// <summary>
		/// Gets or sets the sort column.
		/// </summary>
		/// <value>The sort column.</value>
		public string SortColumn { get; set; }

		/// <summary>
		/// Gets the pager.
		/// </summary>
		/// <value>The pager.</value>
		public Pager Pager { get; private set; }

		/// <summary>
		/// Gets the applied filters.
		/// </summary>
		/// <value>The applied filters.</value>
		public IList<FilterRule<TModel>> AppliedFilters { get; private set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="RequestArgs{TModel}"/> class.
		/// </summary>
		/// <param name="pageNr">The page nr.</param>
		/// <param name="pageSize">Size of the page.</param>
		/// <param name="sortDirection">The sort direction.</param>
		/// <param name="sortColumn">The sort column.</param>
		/// <param name="appliedFilters">The applied filters.</param>
		public RequestArgs(int pageNr, int pageSize, SortDirection sortDirection, string sortColumn, IList<FilterRule<TModel>> appliedFilters)
		{
			Pager = new Pager(pageNr, pageSize, sortColumn, sortDirection);
			AppliedFilters = appliedFilters;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="RequestArgs{TModel}"/> class.
		/// </summary>
		/// <param name="pager">The pager.</param>
		/// <param name="appliedFilters">The applied filters.</param>
		public RequestArgs(Pager pager, IList<FilterRule<TModel>> appliedFilters)
		{
			Pager = pager;
			AppliedFilters = appliedFilters;
		}

		/// <summary>
		/// Gets the filter expression.
		/// </summary>
		/// <returns>Expression&lt;Func&lt;TModel, System.Boolean&gt;&gt;.</returns>
		public Expression<Func<TModel, bool>> GetFilterExpression()
		{
			Expression<Func<TModel, bool>> filterExpression = (e) => true;

			foreach (var filterRule in AppliedFilters)
			{
				filterExpression = PredicateBuilder.And(filterExpression, filterRule.GenerateExpression());
			}

			return filterExpression;
		}
	}
=======
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PSC.Blazor.Components.DataTable.EventsArgs
{
    public class RequestArgs<TModel>
    {
		public int PageNr { get; set; }

		public int PageSize { get; set; }

		public SortDirection SortDirection { get; set; }

		public string SortColumn { get; set; }

		public Pager Pager { get; private set; }

        public IList<FilterRule<TModel>> AppliedFilters { get; private set; }

        public RequestArgs(int pageNr, int pageSize, SortDirection sortDirection, string sortColumn, IList<FilterRule<TModel>> appliedFilters)
        {
            Pager = new Pager(pageNr, pageSize, sortColumn, sortDirection);
            AppliedFilters = appliedFilters;
        }

        public RequestArgs(Pager pager, IList<FilterRule<TModel>> appliedFilters)
        {
            Pager = pager;
            AppliedFilters = appliedFilters;
        }

        public Expression<Func<TModel, bool>> GetFilterExpression()
        {
            Expression<Func<TModel, bool>> filterExpression = (e) => true;

            foreach (var filterRule in AppliedFilters)
            {
                filterExpression = PredicateBuilder.And(filterExpression, filterRule.GenerateExpression());
            }

            return filterExpression;
        }
    }
>>>>>>> 8067c1cc92c53e34d87ef71bf5c8fe928812459e
}