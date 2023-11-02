import { Button, Table, Modal, ModalHeader, ModalBody, ModalFooter } from "reactstrap"

const ModalProduct = ({ dataProduct, mostrarModalProduct, setMostrarModalProduct }) => {

    return (
        <Modal isOpen={mostrarModalProduct}>
            <ModalHeader>
                Lista de Clientes
            </ModalHeader>
            <ModalBody>
                <Table striped responsive>
                    <thead>
                        <tr>
                            <th> Id</th>
                            <th> Descripcion del Producto</th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
                        {
                            (dataProduct.length < 1) ? (
                                <tr>
                                    <td colSpan="3"> Sin Registros</td>
                                </tr>
                            ) : (
                                dataProduct.map((item) => (
                                    <tr key={item.productId}>
                                        <td>{item.productId}</td>
                                        <td>{item.productDescripcion}</td>
                                        <td>
                                            <Button color="primary" size="sm" className="me-2">Seleccionar</Button>
                                        </td>
                                    </tr>
                                ))
                            )
                        }
                    </tbody>
                </Table>
            </ModalBody>
            <ModalFooter>
                <Button color="danger" size="sm" onClick={() => setMostrarModalProduct(!mostrarModalProduct)}>Cerrar</Button>
            </ModalFooter>
        </Modal>
    )
}

export default ModalProduct;