const json = '{"id":1234,"name":"小書屋 001 號"}'

// 儲存了植物資訊的 JSON 字串
const plant_json = '{"name":"一棵大樹","height":5}'
// 將 JSON 字串轉換為一個 JavaScript 物件
const plant = JSON.parse(plant_json)

// 修改資訊，並將 JavaScript 物件轉換為 JSON 字串
plant.height = 7
console.log(JSON.stringify(plant))