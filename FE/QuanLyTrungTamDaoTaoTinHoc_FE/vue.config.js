const { defineConfig } = require('@vue/cli-service')
module.exports = defineConfig({
  transpileDependencies: true,
  devServer: {
    allowedHosts: 'all', // Tắt kiểm tra tiêu đề Host
    headers: {
      'Access-Control-Allow-Origin': '*',
      // Thêm các header cần thiết khác nếu cần
    },
    client: {
      webSocketURL: "https://741e-2001-ee0-40c1-185f-18fa-afff-914-4783.ngrok-free.app", // URL WebSocket 
    },
  },
})
