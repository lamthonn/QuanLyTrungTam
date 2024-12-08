<template>
  <a-modal
    v-model:open="visible"
    width="30%"
    title="Điền thông tin tài khoản"
    :centered="true"
    :footer="false"
    @update:open="handleModalChange"
    class="addNewCourse"
  >
    <form @submit.prevent="handleSubmit" class="FormPayment">
      <div id="card-element">
        <!-- Stripe form sẽ được nhúng ở đây -->
      </div>
      <div id="card-errors" role="alert"></div>
      <button
        type="submit"
        style="height: 60px; font-size: 20px"
        :disabled="loading"
      >
        Thanh toán
      </button>
    </form>
  </a-modal>
</template>
  
  <script>
import { computed, onMounted, ref } from "vue";
import { Modal, FormItem, Input,  } from "ant-design-vue/es/components";
import { loadStripe } from "@stripe/stripe-js";
import app_config from "@/store/config";
import apiUrl from "@/store/api";
import axios from "axios";

export default {
  components: {
    AModal: Modal,
    AFormItem: FormItem,
    AInput: Input,
  },
  setup() {
    const visible = ref(false);
    const username = computed(() => localStorage.getItem("USERNAME"));
    const stripe = ref(null);
    const elements = ref(null);
    const card = ref(null);
    const loading = ref(false);
    const dataByMaKH = ref('')

    const handleSubmit = async () => {
      loading.value = true;
      try {
        const { data } = await axios.post(apiUrl.CREATE_CHECKOUT_SESION, {
          successUrl: app_config.HOST_PATH,
          cancelUrl: app_config.HOST_PATH,
          priceInCents: 200000,
          productName: "Khóa học",
          userId: username.value,
          khoahocId: dataByMaKH.value.maKH,
        });
        const result = await stripe.value.redirectToCheckout({
          sessionId: data.sessionId,
        });
        if (result.error) {
          document.getElementById("card-errors").textContent =
            result.error.message;
        }
      } catch (error) {
        console.log("error::", error);
        
        document.getElementById("card-errors").textContent =
          "Tạo phiên thanh toán không thành công do chưa nhập số tài khoản hoặc số tài khoản chưa hợp lệ!";
      }
      loading.value = false;
    };

    const handleModalChange = async () => {
        try {
          stripe.value = await loadStripe(app_config.stripe_key);
          elements.value = stripe.value.elements();
          card.value = elements.value.create("card");
          card.value.mount("#card-element");
          console.log("Stripe đã sẵn sàng");
        } catch (error) {
          console.error("Lỗi khi khởi tạo Stripe:", error);
        }
    };

    return {
      dataByMaKH,
      stripe,
      elements,
      card,
      loading,
      visible,
      handleSubmit,
      username,
      handleModalChange,
    };
  },
  
  mounted(){
        const MaKH = this.$route.params.maKH;
        
        const getData = async () => {
            await axios.get(`https://localhost:7255/api/KhoaHoc/${MaKH}`)
                    .then(async res => this.dataByMaKH = res.data)
                    .catch((err)=>{
                        notification.open({
                            message: `${err}`,
                            });
                    })
        }
        getData();
    }
};

</script>
  
  <style scoped>
#card-element {
  padding: 10px;
  border: 1px solid #ccc;
  border-radius: 5px;
  margin-bottom: 20px;
}

#card-errors {
  color: red;
}

button {
  background-color: #6772e5;
  color: #fff;
  padding: 10px;
  border: none;
  cursor: pointer;
}

button:disabled {
  background-color: #ccc;
}
</style>
  