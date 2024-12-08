
import { Modal } from 'bootstrap';
<template>
    <a-modal v-model:open="visible" title="đăng bài viết mới" width="80%" :centered="true" @ok="handleOk">
        <a-form-item label="Title">
            <a-input v-model:value="title" />
        </a-form-item>
        <a-form-item label="Upload">
            <!-- <input type="file" list-type="picture-card" :max-count="1" @change="handleInput"> -->
            <a-upload list-type="picture-card" action="/img" :max-count="1" v-model:file-list="image">
                <div>
                    <PlusOutlined />
                    <div style="margin-top: 8px">Upload</div>
                </div>
            </a-upload>
        </a-form-item>
    </a-modal>
</template>
<script>
import { computed, reactive, ref } from 'vue';
import { Modal, FormItem, Input, Upload } from 'ant-design-vue/es/components'
import { PlusOutlined } from '@ant-design/icons-vue';
import { useStore } from 'vuex';
export default {
    components: {
        AModal: Modal,
        AFormItem: FormItem,
        AInput: Input,
        AUpload: Upload,

        PlusOutlined,
    },
    setup() {
        const store = useStore();
        const visible = ref(false);
        const username = ref(localStorage.getItem("USERNAME"));
        const usernameData = computed(() => store.state.username);
        const newPost = reactive({
            maHV:usernameData.value === '' ? username.value : usernameData.value,
            title: '',
            image: null,
        })
        const handleOk =async () => {
            
        }
        


        return {
            store,
            visible,
            newPost,
            username,
            usernameData,

            handleOk,
        }
    }
}
</script>
