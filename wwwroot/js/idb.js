var db = new Dexie("uebDB");
db.version(1).stores({
    CommandHistory: '++id, commandString, latestExecDateTime'
});

