﻿namespace MySql.Data.MySqlClient
{
    public class MySqlTrigger
    {
        string _name = string.Empty;
        string _createTriggerSQL = string.Empty;
        string _createTriggerSQLWithoutDefiner = string.Empty;

        public string Name { get { return _name; } }
        public string CreateTriggerSQL { get { return _createTriggerSQL; } }
        public string CreateTriggerSQLWithoutDefiner { get { return _createTriggerSQLWithoutDefiner; } }

        public MySqlTrigger(MySqlCommand cmd, string triggerName, string definer)
        {
            _name = triggerName;

            _createTriggerSQL = QueryExpress.ExecuteScalarStr(cmd, string.Format("SHOW CREATE TRIGGER `{0}`;", QueryExpress.EscapeIdentifier(triggerName)), 2);

            _createTriggerSQL = _createTriggerSQL.Replace("\r\n", "^~~~~~~~~~~~~~~^");
            _createTriggerSQL = _createTriggerSQL.Replace("\n", "^~~~~~~~~~~~~~~^");
            _createTriggerSQL = _createTriggerSQL.Replace("\r", "^~~~~~~~~~~~~~~^");
            _createTriggerSQL = _createTriggerSQL.Replace("^~~~~~~~~~~~~~~^", "\r\n");

            string[] sa = definer.Split('@');
            definer = string.Format(" DEFINER=`{0}`@`{1}`", sa[0], sa[1]);

            _createTriggerSQLWithoutDefiner = _createTriggerSQL.Replace(definer, string.Empty);
        }
    }
}
