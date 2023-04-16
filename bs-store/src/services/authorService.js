import axios from "axios";

class AuthorService {
  constructor() {
    this.baseUrl = `${process.env.REACT_APP_BASEURL}/authors`;
  }

  async getAllAuthors() {
    return await axios.get(this.baseUrl).then((resp) => resp.data);
  }

  async getOneAuthor(id) {
    const url = `${this.baseUrl}/${id}`;
    return await axios.get(url).then((resp) => resp.data);
  }

  async createOneAuthor(author) {
    return await axios.post(this.baseUrl, author).then((resp) => resp.data);
  }

  async updateOneAuthor(id, author) {
    const url = `${this.baseUrl}/${id}`;
    return await axios.put(url, author).then((resp) => resp.data);
  }

  async deleteOneAuthor(id) {
    const url = `${this.baseUrl}/${id}`;
    return await axios.delete(url).then((resp) => resp.status);
  }
}
export default AuthorService;
