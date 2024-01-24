const json = '{"id":1234,"name":"小书屋 001 号"}'

// 存储了植物信息的 JSON 字符串
const plant_json = '{"name":"一棵大树","height":5}'
// 将 JSON 字符串转换为一个 JavaScript 对象
const plant = JSON.parse(plant_json)

// 修改信息，并将 JavaScript 对象转换为 JSON 字符串
plant.height = 7
console.log(JSON.stringify(plant))