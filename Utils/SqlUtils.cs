using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;

namespace ManyWho.Flow.SDK.Utils
{
    public class SqlUtils
    {
        public static String ConvertCriteriaTypeToSql(String criteriaType, String likeValue)
        {
            String sql = null;

            if (criteriaType == null ||
                criteriaType.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.BadRequest, "Criteria type cannot be null or blank.");
            }

            else if (criteriaType.Equals(ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_STARTS_WITH, StringComparison.OrdinalIgnoreCase) == true ||
                     criteriaType.Equals(ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_ENDS_WITH, StringComparison.OrdinalIgnoreCase) == true ||
                     criteriaType.Equals(ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_CONTAINS, StringComparison.OrdinalIgnoreCase) == true)
            {
                if (likeValue == null ||
                    likeValue.Trim().Length == 0)
                {
                    throw ErrorUtils.GetWebException(HttpStatusCode.BadRequest, "The LIKE value must be provided for the specified criteria type: " + criteriaType);
                }
            }

            if (criteriaType.Equals(ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_EQUAL, StringComparison.OrdinalIgnoreCase) == true)
            {
                sql += " =";
            }
            else if (criteriaType.Equals(ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_GREATER_THAN, StringComparison.OrdinalIgnoreCase) == true)
            {
                sql += " >";
            }
            else if (criteriaType.Equals(ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_GREATER_THAN_OR_EQUAL, StringComparison.OrdinalIgnoreCase) == true)
            {
                sql += " >=";
            }
            else if (criteriaType.Equals(ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_LESS_THAN, StringComparison.OrdinalIgnoreCase) == true)
            {
                sql += " <";
            }
            else if (criteriaType.Equals(ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_LESS_THAN_OR_EQUAL, StringComparison.OrdinalIgnoreCase) == true)
            {
                sql += " <=";
            }
            else if (criteriaType.Equals(ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_NOT_EQUAL, StringComparison.OrdinalIgnoreCase) == true)
            {
                sql += " !=";
            }
            else if (criteriaType.Equals(ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_STARTS_WITH, StringComparison.OrdinalIgnoreCase) == true ||
                     criteriaType.Equals(ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_ENDS_WITH, StringComparison.OrdinalIgnoreCase) == true ||
                     criteriaType.Equals(ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_CONTAINS, StringComparison.OrdinalIgnoreCase) == true)
            {
                sql += " LIKE";
            }
            else
            {
                throw new NotImplementedException();
            }

            if (criteriaType.Equals(ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_STARTS_WITH, StringComparison.OrdinalIgnoreCase) == true)
            {
                sql += " '" + likeValue + "%'";
            }
            else if (criteriaType.Equals(ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_ENDS_WITH, StringComparison.OrdinalIgnoreCase) == true)
            {
                sql += " '%" + likeValue + "'";
            }
            else if (criteriaType.Equals(ManyWhoConstants.CONTENT_VALUE_IMPLEMENTATION_CRITERIA_TYPE_CONTAINS, StringComparison.OrdinalIgnoreCase) == true)
            {
                sql += " '%" + likeValue + "%'";
            }
            else
            {
                sql += " '" + likeValue + "'";
            }

            return sql;
        }
    }
}
